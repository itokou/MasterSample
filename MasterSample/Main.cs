using System;
using System.Collections.Generic;

namespace MasterSample
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			List<TestMaster> testMasters = GenerateTestMaster ();
			List<TestLevelMaster> testLevelMasters = GenerateTestLevelMaster ();

			foreach (var m in testMasters) {
				m.Link(testLevelMasters);
			}

			foreach (var m in testMasters) {

				Console.WriteLine(m.ToString());
			}

			//TestMaster.Cultures[cultureType].Levels[level]



		}

		static List<TestMaster> GenerateTestMaster()
		{
			List<TestMaster> testMasters = new List<TestMaster> ();
			for (int i = 0; i < 10; i++) {
				TestMaster master = new TestMaster();
				master.Code = i+1;
				testMasters.Add(master);
			}
			return testMasters;
		}

		static List<TestLevelMaster> GenerateTestLevelMaster()
		{
			List<TestLevelMaster> masters = new List<TestLevelMaster> ();

			int count = 0;
			for (int i = 0; i< 10; i++) {
				for (int j = 0; j < 10; j++) {
					for (int k = 0; k < 4; k++) {
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
