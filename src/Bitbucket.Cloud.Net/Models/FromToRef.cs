﻿namespace Bitbucket.Cloud.Net.Models
{
	public class FromToRef
	{
		public CommitInfo Commit { get; set; }
		public RepositoryInfo Repository { get; set; }
		public BranchName Branch { get; set; }
	}
}