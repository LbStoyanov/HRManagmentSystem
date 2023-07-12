﻿using HR.ManagmentSystem.Domain;

namespace HR.ManagmentSystem.Aplication.Contracts.Persistence;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetAsync();

    Task<T> GetByIdAsync(int id);
    Task<T> CreateAsync(T entity);

    Task<T> UpdateAsync(T entity);

    Task<T> DeleteAsync(T entity);

}
public interface ILeaveTypeReository<T> : IGenericRepository<LeaveType>
{

}
