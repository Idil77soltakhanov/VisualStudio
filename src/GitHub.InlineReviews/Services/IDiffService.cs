﻿using System.Collections.Generic;
using System.Threading.Tasks;
using GitHub.Models;
using LibGit2Sharp;

namespace GitHub.InlineReviews.Services
{
    public interface IDiffService
    {
        Task<IList<DiffChunk>> Diff(IRepository repo, string baseSha, string relativePath, byte[] contents);
        IEnumerable<DiffChunk> ParseFragment(string diff);
    }
}