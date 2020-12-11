using System;

namespace ProgrammingAssignment1
{
	class DateOb
	{
		public DateTime this[int i] => Date.AddDays(i);
		public DateTime Date { get; set; }
		public DateOb(DateTime date) => Date = date;
	}
}
