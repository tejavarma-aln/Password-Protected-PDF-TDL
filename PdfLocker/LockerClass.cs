using iTextSharp.text.pdf;
using System;
using System.IO;
 
namespace PdfLocker
{
    public class LockerClass
    {


        public string doencrypt(string fpath,string upass,string opass)
        {

            if (!File.Exists(fpath))
            {
                return ("File Not Found");
            }
            if(String.IsNullOrEmpty(upass) || String.IsNullOrEmpty(opass))
            {
                return ("Invalid Security Keys");
            }
            string outdir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Encrypted PDFs");

            if (!Directory.Exists(outdir))
            {
                Directory.CreateDirectory(outdir);
            }

            string outfilename = "Encrypted-" + Path.GetFileName(fpath);
            string outfile = Path.Combine(outdir, outfilename);

            try
            {
              
                using (Stream input = new FileStream(fpath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (Stream output = new FileStream(outfile, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        PdfReader reader = new PdfReader(input);
                        PdfEncryptor.Encrypt(reader, output, true, upass, opass, PdfWriter.ALLOW_SCREENREADERS);
                    }
                }
            }catch(Exception ex)
            {
                return ("Error : " + ex.Message);
            }

            return "File Enctrypted at " +outfile ;


        }

    }
}
