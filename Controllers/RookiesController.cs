using Microsoft.AspNetCore.Mvc;
using mvc.Services;

namespace mvc.Controllers
{
    [Route("NashTech")]
    public class RookiesController : Controller
    {
        private MemberServices _service;

        [Route("Rookies/Index")]
        public IActionResult Index()
        {
            return View(_service.getViewList());
        }
        public RookiesController()
        {
            _service = new MemberServices();
        }
        public IActionResult OldestOnes()
        {
            return View(_service.getOldestOnes());
        }
        public IActionResult GetFullNames()
        {
            return View(_service.getFullNames());
        }
        public IActionResult GetMembersBasedOnAge(int number)
        {
            return View(_service.GetMembersBasedOnAge(number));
        }
        public IActionResult Export()
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook excelworkBook;
            Microsoft.Office.Interop.Excel.Worksheet excelSheet;
            var data = _service.getData();
            string filename = @"D:\Test.xlsx";

            excel = new Microsoft.Office.Interop.Excel.Application();
            // for making Excel visible  
            excel.Visible = false;
            excel.DisplayAlerts = false;
            // Creation a new Workbook  
            excelworkBook = excel.Workbooks.Add(Type.Missing);
            // Work sheet  
            excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;
            excelSheet.Name = "Data";

            int index = 1;
            foreach (var row in data)
            {
                int column = 1;
                excelSheet.Cells[index, column] = row.FirstName;
                column++;
                excelSheet.Cells[index, column] = row.LastName;
                column++;
                excelSheet.Cells[index, column] = row.Gender;
                column++;
                excelSheet.Cells[index, column] = row.DateOfBirth.Value.ToString("dd/MM/yyyy");
                column++;
                excelSheet.Cells[index, column] = row.PhoneNumber;
                column++;
                excelSheet.Cells[index, column] = row.BirthPlace;
                column++;
                excelSheet.Cells[index, column] = row.IsGraduated;
                column++;
                index++;
            }
            excelworkBook.SaveAs(filename); ;
            excelworkBook.Close();
            excel.Quit();
            return RedirectToAction("Index");
        }

    }
}
