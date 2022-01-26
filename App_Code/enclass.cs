using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Security.Cryptography;
using System.Data;
using System.Text;

using System.Data.SqlClient;

/// <summary>
/// Summary description for enclass
/// </summary>
public class enclass
{
	public enclass()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static void EncryptFile(string inputFile, string outputFile, string skey)
    {
        try
        {
            using (Aes aes = Aes.Create())
            {
                byte[] key = ASCIIEncoding.UTF8.GetBytes(skey);

                /* This is for demostrating purposes only. 
                 * Ideally you will want the IV key to be different from your key and you should always generate a new one for each encryption in other to achieve maximum security*/
                byte[] IV = ASCIIEncoding.UTF8.GetBytes(skey);

                using (FileStream fsCrypt = new FileStream(outputFile, FileMode.Create))
                {
                    using (ICryptoTransform encryptor = aes.CreateEncryptor(key, IV))
                    {
                        using (CryptoStream cs = new CryptoStream(fsCrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (FileStream fsIn = new FileStream(inputFile, FileMode.Open))
                            {
                                int data;
                                while ((data = fsIn.ReadByte()) != -1)
                                {
                                    cs.WriteByte((byte)data);
                                }
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // failed to encrypt file
        }
    }
    public static void SignFile(byte[] key, String sourceFile, String destFile)
    {
        // Initialize the keyed hash object. 
        using (HMACMD5 hmac = new HMACMD5(key))
        {
            using (FileStream inStream = new FileStream(sourceFile, FileMode.Open))
            {
                using (FileStream outStream = new FileStream(destFile, FileMode.Create))
                {
                    // Compute the hash of the input file. 
                    byte[] hashValue = hmac.ComputeHash(inStream);
                    // Reset inStream to the beginning of the file.
                    inStream.Position = 0;
                    // Write the computed hash value to the output file.
                    outStream.Write(hashValue, 0, hashValue.Length);
                    // Copy the contents of the sourceFile to the destFile. 
                    int bytesRead;
                    // read 1K at a time 
                    byte[] buffer = new byte[1024];
                    do
                    {
                        // Read from the wrapping CryptoStream.
                        bytesRead = inStream.Read(buffer, 0, 1024);
                        outStream.Write(buffer, 0, bytesRead);
                    } while (bytesRead > 0);
                }
            }
        }
        return;
    } // end S
    public static bool VerifyFile(byte[] key, String sourceFile,string fl1)
    {
        bool err = false;
        // Initialize the keyed hash object.  
        using (HMACMD5 hmac = new HMACMD5(key))
        {
            // Create an array to hold the keyed hash value read from the file. 
            byte[] storedHash = new byte[hmac.HashSize / 8];
            // Create a FileStream for the source file. 
            using (FileStream inStream = new FileStream(sourceFile, FileMode.Open))
            {
                // Read in the storedHash.
                inStream.Read(storedHash, 0, storedHash.Length);
                // Compute the hash of the remaining contents of the file. 
                // The stream is properly positioned at the beginning of the content,  
                // immediately after the stored hash value. 
                byte[] computedHash = hmac.ComputeHash(inStream);
                // compare the computed hash with the stored value 

                for (int i = 0; i < storedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i])
                    {
                        err = true;
                    }
                }
            }
        }
        if (err)
        {

            return true;
            // Response.Write("<script> alert('success  ')</script>");


        }
        else
        {
            // Console.WriteLine("Hash values agree -- no tampering occurred.");
            // Console.ReadLine();
            try
            {
                using (Aes aes = Aes.Create())
                {
                    byte[] key1 = ASCIIEncoding.UTF8.GetBytes("1234512345678976");

                    /* This is for demostrating purposes only. 
                     * Ideally you will want the IV key to be different from your key and you should always generate a new one for each encryption in other to achieve maximum security*/
                    byte[] IV = ASCIIEncoding.UTF8.GetBytes("1234512345678976");


                    using (FileStream fsOut = new FileStream(@"C:\Users\ameer-pc\Documents\Visual Studio 2010\WebSites\project3\Files3\" + fl1, FileMode.Create))
                    {
                        using (ICryptoTransform decryptor = aes.CreateDecryptor(key1, IV))
                        {
                            using (HMACMD5 hmac = new HMACMD5(key))
                            {
                                // Create an array to hold the keyed hash value read from the file. 
                                byte[] storedHash = new byte[hmac.HashSize / 8];
                                // Create a FileStream for the source file. 
                                using (FileStream inStream = new FileStream(sourceFile, FileMode.Open))
                                {
                                    // Read in the storedHash.
                                    inStream.Read(storedHash, 0, storedHash.Length);
                                    using (CryptoStream cs = new CryptoStream(inStream, decryptor, CryptoStreamMode.Read))
                                    {
                                        int data;
                                        while ((data = cs.ReadByte()) != -1)
                                        {
                                            fsOut.WriteByte((byte)data);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
               
            }

            catch (Exception ex)
            { }
            return false;
            
            
        }

    } //end
    public static string encypt1(string s)
    {
        string a = s;
        string skey = "1234512345678976";
        string b;
        byte[] c;
        string EncryptionKey = "1234512345678976";
        byte[] clearBytes = Encoding.Unicode.GetBytes(a);
        // byte[] clearBytes = Convert.FromBase64String(a);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            encryptor.Key = pdb.GetBytes(32);

            encryptor.IV = pdb.GetBytes(16);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(clearBytes, 0, clearBytes.Length);
                    //cs.Close();



                    cs.Close();


                    b = Convert.ToBase64String(ms.ToArray());


                }
            }


            //TextBox2.Text = b;
            byte[] abc = Encoding.Unicode.GetBytes(b);
            byte[] k5 = ASCIIEncoding.UTF8.GetBytes(skey);
            byte[] abc1 = Convert.FromBase64String(b);
            using (HMACMD5 hmac = new HMACMD5(k5))
            {
                // byte[] myByteArray = new byte[10];
                MemoryStream stream = new MemoryStream();
                stream.Write(abc1, 0, abc1.Length);
                stream.Position = 0;
                // Compute the hash of the input file. 
                byte[] hashValue = hmac.ComputeHash(stream);
                // Reset inStream to the beginning of the file.

                MemoryStream stream1 = new MemoryStream();
                stream1.Write(hashValue, 0, hashValue.Length);
                stream1.Write(abc1, 0, abc1.Length);
                // Write the computed hash value to the output file.
                // cs.Write(hashValue, 0, hashValue.Length);
                // Copy the contents of the sourceFile to the destFile. 
                /*  int bytesRead;
                  // read 1K at a time 
                  byte[] buffer = new byte[1024];
                  do
                  {
                      // Read from the wrapping CryptoStream.
                      bytesRead = stream.Read(buffer, 0, 1024);
                      stream1.Write(buffer, 0, bytesRead);
                  } while (bytesRead > 0);*/
                //string c2 = Encoding.Unicode.GetString(stream1.ToArray());
                //byte[] bytes = Encoding.UTF8.GetBytes(c2);
                string c2 = Convert.ToBase64String(stream1.ToArray());
                //string c3 = Convert.ToBase64String(c2);
                // string d1 = Convert.ToBase64String(stream1.ToArray());
                return c2;
                //TextBox2.Text = c2;
            }
        }
    }
    public static string decrypt1(string s1)
    {
        string EncryptionKey = "1234512345678976";
        string b = s1;
        int cc = b.Length;
        if (cc != 44 && cc != 64 && cc != 88 && cc != 108 && cc != 172)
        {

            return "t";
        }
        else
        {
            string c;
            int kp = 0;
            // byte[] cipherBytes= Encoding.Unicode.GetBytes(b);
            byte[] cipherBytes = Convert.FromBase64String(b);
            byte[] a2 = new byte[cipherBytes.Length - 16];
            byte[] k5 = ASCIIEncoding.UTF8.GetBytes(EncryptionKey);
            //byte[] cipherBytes = Convert.FromBase64String(b);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (HMACMD5 hmac = new HMACMD5(k5))
                    {
                        // Create an array to hold the keyed hash value read from the file. 
                        byte[] storedHash = new byte[hmac.HashSize / 8];
                        // Create a FileStream for the source file. 

                        // Read in the storedHash.
                        // ms.Read(storedHash, 0, storedHash.Length);
                        for (int i1 = 0; i1 < storedHash.Length; i1++)
                        {
                            storedHash[i1] = cipherBytes[i1];
                        }
                        int k3 = 0;
                        for (int i2 = storedHash.Length; i2 < cipherBytes.Length; i2++)
                        {
                            a2[k3] = cipherBytes[i2];
                            k3++;
                        }
                        // Compute the hash of the remaining contents of the file. 
                        // The stream is properly positioned at the beginning of the content,  
                        // immediately after the stored hash value. 
                        MemoryStream stream5 = new MemoryStream();
                        stream5.Write(a2, 0, a2.Length);
                        stream5.Position = 0;
                        byte[] computedHash = hmac.ComputeHash(stream5);
                        // compare the computed hash with the stored value 

                        for (int i = 0; i < storedHash.Length; i++)
                        {
                            if (computedHash[i] != storedHash[i])
                            {
                                kp = 1;

                            }
                        }
                    }
                    if (kp == 0)
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(a2, 0, a2.Length);

                            cs.Close();
                        }
                        c = Encoding.Unicode.GetString(ms.ToArray());
                        return c;
                        //TextBox4.Text = c;

                    }
                    else
                    {
                        return "t";
                        //Response.Write("<script> alert('Tampered')</script>");
                    }
                }
            }
        }
    }
}