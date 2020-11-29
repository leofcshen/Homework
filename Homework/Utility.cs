using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
	internal struct StructGrade // Struct 分數
	{		
		internal string Name; // 姓名		
		internal int CN; // 國文分數
		internal int EN; // 英文分數
		internal int Math; // 數學分數
		internal string MajorMax; // 最高分科目及分數
		internal string MajorMin; // 最低分科目及分數
		internal double Avg; // 平均分數
		internal double Sum; // 總和分數
	}
	internal struct StructStatistics // Struct 統計
	{		
		internal int MaxEN; // 英文最高分
		internal int MaxCN; // 中文最高分
		internal int MaxMath; // 數學最高分
		internal int MinEN; // 英文最低分
		internal int MinCN; // 中文最低分
		internal int MinMath; // 數學最低分
		internal double TEN; // 英文總和
		internal double TCN; // 中文總和
		internal double TMath; // 數學總和
		internal double AvgEN; // 英文平均
        internal double AvgCN; // 中文平均
        internal double AvgMath; // 數學平均
    }
	internal class ClassDataPass
    {
		internal static Form15_GuessNumber fg;
		internal static int answer;
	}
}
