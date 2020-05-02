# Password-Protected-PDF-TDL

**Highlights**

1)Exports Ledger Statements and Sales Invoices to PDF with Password Protected

2)There are two Kinds of Password - User password and Owner Password

3)With user password they can view the pdf but cannot alter

4)Screen readers are allowed to read the content

**Requirements**

1)PdfLocker.dll - for password protection

2)PdfLocker.txt(TDL) - for handling export and Invoking dll from tally

3).Net Framework v4 or higher 

    You can Download from here : https://dotnet.microsoft.com/download/dotnet-framework/net40
    
**Get Started**

1)Download all the files (PdfLocker.dll,PdfLocker.txt,itextsharp.dll)

2)Register the dll - PdfLocker.dll (with below steps)

3)Load the tcp in tally - PdfLocker.txt

4)Export Ledger Statement or Slaes Invoices by clicking on Encrypt PDF Button (Right Side)

5)It will ask for user password and owner password

6)After that Report will be exported and Encrypted with given passwords

7)PDF's will be Stored in Encrypted PDF's folder in Tally working directory(Tally Folder)


** Registering the DLL**

2) Open CMD in administrator Mode (Elevated mode)

           For 64 Bit
3) Type cd C:\Windows\Microsoft.NET\Framework64\v4.0.30319 ;; change directory

           For 32 Bit
3) Type cd C:\Windows\Microsoft.NET\Framework\v4.0.30319 ;; change directory


4) Type regasm PdfLocker.dll /codebase ;;Give Full path of the PdfLocker.dll file

5) you will get success message after it registered



**You can extend the tdl as per your requirements**

    

