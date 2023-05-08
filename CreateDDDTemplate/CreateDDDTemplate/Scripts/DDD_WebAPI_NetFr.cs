using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDDDTemplate.Scripts
{
	public class DDD_WebAPI_NetFr : IBuildable
	{
		private string _path;
		private string _name;

		private string _baseRepo;

		public DDD_WebAPI_NetFr(string path, string name)
		{
			_path = Path.GetFullPath(path);
			_name = name.Replace(" ", "_");

			_baseRepo = _path + "/" + _name;
		}



		public bool Build()
		{
			if (!Directory.Exists(_baseRepo)) Directory.CreateDirectory(_baseRepo);
			if (Directory.GetFileSystemEntries(_baseRepo).Length > 0) throw new ArgumentException("Directory is not empty");




			Utils.Execute("dotnet", "new sln -n \"\"");
			return true;
		}
	}
}
