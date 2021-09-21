using AutoMapper;
using Contracts;
using Entities.Models;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RunsheetsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RunsheetController : ControllerBase
    {
        private readonly ILogger<RunsheetController> _logger;
        private readonly IRepositoryWrapper _repo;
        private readonly IMapper _mapper;
        public RunsheetController(ILogger<RunsheetController> logger, IRepositoryWrapper repo, IMapper mapper)
        {
            _logger = logger;
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet("inputType/{inputTypeId}")]
        public IActionResult GetAllRunsheetsForInputType(int inputTypeId)
        {
            try
            {
                var Runsheets = _repo.Runsheet.GetAllRunsheetsForInputType(inputTypeId);
                if(Runsheets == null)
                {
                    _logger.LogError($"Runsheets for inputType: {inputTypeId}, could not be found in the database.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInformation($"Returned Runsheets for InputTypeId: {inputTypeId}");
                    var RunsheetResults = _mapper.Map<IEnumerable<RunsheetDto>>(Runsheets);
                    return Ok(RunsheetResults);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the GetAllRunsheetsForInputType Action {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpGet("{id}/Datafields")]
        public IActionResult GetRunsheetWithDatafields(int id)
        {
            try
            {
                var Runsheets = _repo.Runsheet.GetRunsheetWithSubsectionAndDatafields(id);
                if (Runsheets == null)
                {
                    _logger.LogError($"Runsheet with id: {id}, could not be found in the database.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInformation($"Returned Runsheet for Id: {id}");
                    var RunsheetResults = _mapper.Map<RunsheetDto>(Runsheets);
                    return Ok(RunsheetResults);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the GetRunsheetWithDatafields Action {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpGet("{id}/{date}")]
        public IActionResult GetRunsheetsWithDatafieldsAndReportData(int id, DateTime date)
        {
            try
            {
                var Runsheets = _repo.Runsheet.GetRunsheetWithDatafieldsAndReports(id,date);
                if (Runsheets == null)
                {
                    _logger.LogError($"Runsheet with id: {id}, date: {date}, could not be found in the database.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInformation($"Returned Runsheet for Id: {id} with ReportDate from {date}");
                    var RunsheetResults = _mapper.Map<RunsheetDto>(Runsheets);
                    return Ok(RunsheetResults);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the GetRunsheetsWithDatafieldsAndReportData Action {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpGet("ReportEntry/{id}")]
        public IActionResult GetReportEntry(int id)
        {
            try
            {
                var reportEntry = _repo.ReportEntry.GetReportByID(id);
                if (reportEntry == null)
                {
                    _logger.LogError($"Report Entry with id: {id}, could not be found in the database.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInformation($"Returned Runsheet for Id: {id}");
                    var RunsheetResults = _mapper.Map<ReportEntryDto>(reportEntry);
                    return Ok(RunsheetResults);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the GetReportEntry Action {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpPost]
        public IActionResult PostReportEntry([FromBody] ReportEntryForUpdateDto ReportEntry)
        {
            try
            {

                if(ReportEntry == null)
                {
                    _logger.LogError("ReportEntry object sent from client is null.");
                    return BadRequest("ReportEntry object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid ReportEntry object sent from client.");
                    return BadRequest("Invalid model object");
                }

                var ReportEntryEntity = _mapper.Map<ReportEntry>(ReportEntry);

                _repo.ReportEntry.CreateReportEntry(ReportEntryEntity);
                _repo.Save();

                var CreatedReport = _mapper.Map<ReportEntryDto>(ReportEntryEntity);
                //this return throws an error in swagger right now. 
                return CreatedAtRoute("ReportEntry", new { id = CreatedReport.ID }, CreatedReport);
             
            }
            catch(Exception ex)
            {
                _logger.LogError($"Something went wrong in the PostRunsheet Action {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
        }
       
            

        // GET: api/Runsheet
        [HttpGet]
        public IActionResult Get()
        {
            var Runsheets = _repo.Runsheet.FindAll();

            return Ok(Runsheets);
        }
    }
}
