using docx2pdf.Services;

try
{
    // Get the download folder and create an output directory
    var downloadsFolder = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
        "Downloads"
    );
    var projectName = AppDomain.CurrentDomain.FriendlyName;
    var outDir = Path.Combine(downloadsFolder, $"{projectName}_Files");
    Directory.CreateDirectory(outDir);

    // Set up the URL for the dummy DOCX file
    string dummy_url = "[DOCX_URL_HERE]";

    // Get the bytes array of the dummy DOCX file
    using var httpClient = new HttpClient();
    byte[] dummyDocxBytes = await httpClient.GetByteArrayAsync(dummy_url);

    // Passwords to lock files
    string userPassword = "password123"; // required to open
    string ownerPassword = "owner456"; // owner permissions

    // Output file paths
    var ironPdfPath = Path.Combine(outDir, "output_ironpdf.pdf");
    var asposePdfPath = Path.Combine(outDir, "output_aspose.pdf");

    // Convert with IronPdf
    IronPdfService.ConvertAndProtect(dummyDocxBytes, ironPdfPath, userPassword, ownerPassword);

    // Convert with Aspose
    AsposeService.ConvertAndProtect(dummyDocxBytes, asposePdfPath, userPassword, ownerPassword);
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
    Environment.Exit(1);
}