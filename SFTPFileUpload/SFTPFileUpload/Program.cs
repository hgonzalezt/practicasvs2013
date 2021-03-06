﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Renci.SshNet;
using Renci.SshNet.Sftp;

namespace SFTPFileUpload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create client Object");
            using (SftpClient sftpClient = new SftpClient(getSftpConnection("host", "userName", 22, "filePath")))
            {
                Console.WriteLine("Connect to server");
                sftpClient.Connect();
                Console.WriteLine("Creating FileStream object to stream a file");
                using (FileStream fs = new FileStream("filePath", FileMode.Open))
                {
                    sftpClient.BufferSize = 1024;
                    sftpClient.UploadFile(fs, Path.GetFileName("filePath"));
                }
                sftpClient.Dispose();
            }
        }
        public static ConnectionInfo getSftpConnection(string host, string username, int port, string publicKeyPath)
        {
            return new ConnectionInfo(host, port, username, privateKeyObject(username, publicKeyPath));
        }

        private static AuthenticationMethod[] privateKeyObject(string username, string publicKeyPath)
        {
            PrivateKeyFile privateKeyFile = new PrivateKeyFile(publicKeyPath);
            PrivateKeyAuthenticationMethod privateKeyAuthenticationMethod = new PrivateKeyAuthenticationMethod(username, privateKeyFile);
            return new AuthenticationMethod[] { privateKeyAuthenticationMethod };
        }
       
    }
}
