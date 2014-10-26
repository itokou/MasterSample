using System;
using System.Collections.Generic;
using System.Linq;
namespace MasterSample
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Dictionary<int,TestMaster> testMasters = GenerateTestMaster ();
			List<TestLevelMaster> testLevelMasters = GenerateTestLevelMaster ();
			UpDateLink (testMasters, testLevelMasters);


			//TestMaster.Cultures[cultureType].Levels[level]
		}

		public static void UpDateLink<T1,T2>(Dictionary<int, T1> baseMaster,List<T2> linkedData) where T1 : ILinkMaster<T2>
		{
			foreach (var m in baseMaster)
			{
				m.Value.Link(linkedData);
			}
		}

		static Dictionary<int,TestMaster> GenerateTestMaster()
		{
			Dictionary<int,TestMaster> testMasters = new Dictionary<int,TestMaster> ();
			for (int i = 0; i < 100; i++) {
				TestMaster master = new TestMaster();
				master.Code = i+1;
				testMasters.Add(master.Code,master);
			}
			return testMasters;
		}

		static List<TestLevelMaster> GenerateTestLevelMaster()
		{
			List<TestLevelMaster> masters = new List<TestLevelMaster> ();

			int count = 0;
			for (int i = 0; i< 100; i++) {
				for (int j = 0; j < 100; j++) {
					for (int k = 0; k < 7; k++) {
						TestLevelMaster master = new TestLevelMaster ();
						master.Code = count;
						master.TestCode = i+1;
						master.Level = j+1;
						master.Culture = k;
						count++;
						masters.Add (master);
					}
				}
			}
			return masters;
		}
	}
}
