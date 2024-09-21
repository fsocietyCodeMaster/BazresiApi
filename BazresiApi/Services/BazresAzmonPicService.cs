using AutoMapper;
using BazresiApi.Context;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace BazresiApi.Services
{
    public class BazresAzmonPicService : IGenericRepository<BazresiAzmonPicDto>
    {
        private readonly BazresiDb _context;
        private readonly IMapper _mapper;
        public BazresAzmonPicService(BazresiDb context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<ResponseDto> AddAsync(BazresiAzmonPicDto bazresiAzmonPic)
        {

            if (bazresiAzmonPic == null || string.IsNullOrEmpty(bazresiAzmonPic.Base64data))
            {
                var error = new ResponseDto()
                {
                    Message = "Invalid Request Data.",
                    IsSuccess = false,
                    Status = HttpStatusCode.BadRequest.ToString(),
                };
                return error;
            }
            else
            {


                byte[] fileBytes;

                fileBytes = Convert.FromBase64String(bazresiAzmonPic.Base64data);


                var streaming = new MemoryStream(fileBytes);

                var fileName = Guid.NewGuid().ToString() + "-" + Path.GetExtension(".jpg");

                var uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "AzmonPic");

                string url = Path.Combine(uploadFolder, fileName);

                using (var fileStream = new FileStream(url, FileMode.Create))
                {
                    await streaming.CopyToAsync(fileStream);
                }




                var imageRecord = _mapper.Map<T_Bazresi_Azmon_Pic>(bazresiAzmonPic);

                imageRecord.Name_Pic = fileName;

                imageRecord.Route_Pic = url;

                _context.Add(imageRecord);

                await _context.SaveChangesAsync();


                var success = new ResponseDto
                {
                    Message = "successfully added.",
                    IsSuccess = true,
                    Status = HttpStatusCode.OK.ToString(),
                };
                return success;


            }
        }



        public async Task<ResponseDto> GetAsync(long id)
        {
            var bazresiAzmonPic = await _context.BazresiAzmonPic.Where(c => c.T_AdminsBackups_ID == id).ToListAsync();
            if (bazresiAzmonPic.Any())
            {

                var ImagesPath = new List<string>();

                foreach (var image in bazresiAzmonPic)
                {
                    var imageRoute = image.Route_Pic;
                    if (!System.IO.File.Exists(imageRoute))
                    {
                        var error = new ResponseDto()
                        {
                            Message = "File not found.",
                            IsSuccess = false,
                            Status = HttpStatusCode.BadRequest.ToString(),

                        };

                        return error;
                    }
                    else
                    {
                        ImagesPath.Add(imageRoute);

                    }

                }
                var success = new ResponseDto
                {
                    Message = "successfully retrieved .",
                    IsSuccess = true,
                    Status = HttpStatusCode.OK.ToString(),
                    Data = ImagesPath
                };
                return success;
            }
            else
            {
                var error = new ResponseDto
                {
                    Message = "Nothing found.",
                    IsSuccess = false,
                    Status = HttpStatusCode.NotFound.ToString(),
                };
                return error;
            }
        }


    }
}
