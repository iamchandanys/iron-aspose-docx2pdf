# docx2pdf

## Overview

`docx2pdf` is a .NET 8 console application written in C# 12.0 that demonstrates how to convert DOCX files to password-protected PDF documents using two popular libraries: IronPdf and Aspose.PDF. The application downloads a sample DOCX file, converts it to PDF using both libraries, applies user and owner passwords for protection, and saves the results in your Downloads folder.

## Features

- Downloads a sample DOCX file from a remote URL.
- Converts DOCX to PDF using IronPdf and Aspose.PDF.
- Applies user and owner passwords to protect the generated PDFs.
- Saves output files to a dedicated folder in the user's Downloads directory.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Internet connection (for downloading the sample DOCX file)
- IronPdf and Aspose.PDF NuGet packages

## Installation

1. **Clone the repository:**
2. **Restore NuGet packages:**

## Usage

1. **Build and run the application:**
2. The application will:
   - Download a sample DOCX file from a remote URL.
   - Convert it to PDF using both IronPdf and Aspose.PDF.
   - Protect each PDF with a user password (`password123`) and an owner password (`owner456`).
   - Save the output files in a folder named `docx2pdf_Files` inside your Downloads directory.

## Output

- `output_ironpdf.pdf` — PDF generated using IronPdf.
- `output_aspose.pdf` — PDF generated using Aspose.PDF.

Both files are password-protected. The user password is required to open the PDF.

## Project Structure
- **Program.cs**: Main entry point, orchestrates the download and conversion process.
- **Services/IronPdfService.cs**: Contains logic for converting and protecting PDFs using IronPdf.
- **Services/AsposeService.cs**: Contains logic for converting and protecting PDFs using Aspose.PDF.

## Customization

- You can change the DOCX file URL in `Program.cs` by modifying the `dummy_url` variable.
- Update the user and owner passwords as needed in `Program.cs`.

## Credits

- [IronPdf](https://ironpdf.com/)
- [Aspose.PDF](https://products.aspose.com/pdf/net/)
