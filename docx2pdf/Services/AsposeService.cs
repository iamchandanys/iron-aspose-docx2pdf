using Aspose.Words;
using Aspose.Words.Saving;

namespace docx2pdf.Services
{
    public static class AsposeService
    {
        public static void ConvertAndProtect(byte[] inputFile, string outDir, string userPassword, string ownerPassword)
        {
            using var stream = new MemoryStream(inputFile, writable: false);

            var doc = new Document(stream);

            var encryption = new PdfEncryptionDetails(
                userPassword,
                ownerPassword,
                PdfPermissions.DisallowAll
            );

            var saveOptions = new PdfSaveOptions
            {
                EncryptionDetails = encryption
            };

            doc.Save(outDir, saveOptions);
        }
    }
}
