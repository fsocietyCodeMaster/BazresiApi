using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using Microsoft.AspNetCore.Mvc;
namespace BazresiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BazresiAzmonPicController : ControllerBase
    {

        private readonly IGenericRepository<T_Bazresi_Azmon_Pic> _bazresAzmonPic;
        private readonly IMapper _mapper;
        private readonly ILogger<BazresiAzmonPicController> _logger;

        public BazresiAzmonPicController(IGenericRepository<T_Bazresi_Azmon_Pic> bazresAzmonPic, IMapper mapper, ILogger<BazresiAzmonPicController> logger)
        {
            _logger = logger;
            _bazresAzmonPic = bazresAzmonPic;
            _mapper = mapper;
            _logger = logger;
        }


        #region Get

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResponseDto>>> Get(int id)
        {
            try
            {
                var BazresiAzmonPic = await _bazresAzmonPic.GetAsync(id);

                if (BazresiAzmonPic == null || !BazresiAzmonPic.Any())
                {
                    var error = new NotFoundDto
                    {
                        Status = 404,
                        Message = "Nothing found."

                    };
                    return NotFound(error);
                }

                var success = new ResponseDto
                {
                    Status = 200,
                    Message = "successfully retrieved .",
                    IsSuccess = true,
                    Data = new { Response = _mapper.Map<IEnumerable<BazresiAzmonPicDto>>(BazresiAzmonPic) }
                };

                return Ok(success);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "an error occurred .");

                var error = new ErrorDto
                {
                    Message = "Error.",
                    Success = false
                };

                return BadRequest(error);
            }
        }
        #endregion




        #region Post

        [HttpPost]

        public async Task<ActionResult> UploadAndCreate([FromForm] FileUploadDto upload)
        {

            try
            {
                List<string> validExtention = new List<string>()
                {
                    ".jpg",".png",".gif",".JPEG"
                };

                string extention = Path.GetExtension(upload.File.FileName);

                if (!validExtention.Contains(extention))
                {
                    return BadRequest(new { error = $"file extention is not valid, ({string.Join(',', validExtention)})" });
                }

                long size = upload.File.Length;

                if (upload.File == null || upload.File.Length == 0)
                {
                    return BadRequest("File not selected");
                }

                else if (size > (10 * 1024 * 1024))  
                {
                    return BadRequest(new { error = "Maximum size is 5mb. " });
                }

                var fileName = Guid.NewGuid().ToString() + extention;


                string path = Path.Combine(Directory.GetCurrentDirectory(), "AzmonPic");


                FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create);



                await upload.File.CopyToAsync(stream);


                stream.Dispose();
                stream.Close();

                var newPic = new T_Bazresi_Azmon_Pic()
                {
                    ID_Bazresi_Azmon_PicApp = upload.ID_Bazresi_Azmon_PicApp,
                    T_Bazresi_Azmon_Id = upload.T_Bazresi_Azmon_Id,
                    T_AdminsBackups_ID = upload.T_AdminsBackups_ID,
                    Name_Pic = fileName,
                    Route_Pic = path,
                    Is_Temp = upload.Is_Temp,
                };  

   

                _bazresAzmonPic.add(newPic);
                await _bazresAzmonPic.SaveAsync();

                return Ok(new { Response = "File is uploaded successfully.", status = 200 });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "an error occurred .");

                var error = new ErrorDto
                {
                    Message = "Error.",
                    Success = false
                };

                return BadRequest(error);
            }
        }
        #endregion






    }
}
