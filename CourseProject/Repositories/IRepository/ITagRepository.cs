﻿using CourseProject.Models.Entity;

namespace CourseProject.Repositories.IRepository
{
    public interface ITagRepository
    {
        Task<IEnumerable<Tag>> GetAllAsync();
        Task<Tag?> GetAsync(int id);
        Task<Tag?> UpdateAsync(Tag tag);
    }
}
