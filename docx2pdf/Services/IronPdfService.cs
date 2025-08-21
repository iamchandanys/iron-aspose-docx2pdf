namespace docx2pdf.Services
{
    public static class IronPdfService
    {
        public static void ConvertAndProtect(byte[] inputFile, string outDir, string userPassword, string ownerPassword)
        {
            var renderer = new DocxToPdfRenderer();

            using (var pdf = renderer.RenderDocxAsPdf(inputFile))
            {
                var sec = pdf.SecuritySettings;
                sec.UserPassword = userPassword;
                sec.OwnerPassword = ownerPassword;

                pdf.SaveAs(outDir);
            }
        }
    }
}
