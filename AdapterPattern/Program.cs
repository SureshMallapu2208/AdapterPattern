// See https://aka.ms/new-console-template for more information
using AdapterPattern;


IExport reportExcel = new ExcelExport();
reportExcel.Export(string.Empty);


IExport reportPdf = new PdfExport();
reportPdf.Export(string.Empty);


/*
 Lets Take an Example where if any third party library we are going to use it for exporting purpose 

we wil create a warraper class  and it wil act as aadapter for that third party dll to Export.
 
 */

IExport reportThirdpartyPdf = new Adapter();
reportThirdpartyPdf.Export(string.Empty);
