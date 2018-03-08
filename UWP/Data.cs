using System;
using System.Collections.Generic;
using System.Linq;

namespace UWP
{
	public class Table
	{
		public Table(params (int key, List<DateTime> times)[] records) =>
			this.Records = records.ToDictionary(i => i.key, i => i.times);

		public Table(Dictionary<int, List<DateTime>> records) =>
			this.Records = records;

		public override string ToString() =>
			String.Join("\n", this.Records.Select(i => String.Join("\n", i.Value.Select(j => $"{i.Key} {j}"))));

		public List<DateTime> this[int key] => this.Records[key];

		public Dictionary<int, List<DateTime>> Records;
	}
}
