using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace RCFileUploadApp
{
	public static class FileUtils
	{
		[JSInvokable]
		public static Task<bool> LoadFile(string name, string value)
		{
			byte[] FileData;
			string FileName;
			try
			{
				if (value.Contains(";base64,"))
				{
					FileData = Convert.FromBase64String(value.Substring(value.IndexOf("base64") + 7));
				}
				else
				{
					FileData = GetBytes(value);
				}
				FileName = $"wwwroot\\uploads\\{System.IO.Path.GetFileName(name)}";
				System.IO.File.WriteAllBytes(FileName, FileData);
			}
			catch (Exception ex)
			{
			}
			return Task.FromResult(true);

			byte[] GetBytes(string str)
			{
				byte[] bytes = new byte[str.Length * sizeof(char)];
				System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
				return bytes;
			}
		}
	}
}
