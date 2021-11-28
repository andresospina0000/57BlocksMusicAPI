using _57Blocks.Music.DataModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _57Blocks.Music.BLogic.Contracts
{
    public interface IUserAplicationService
    {
        /// <summary>
        /// Gets all the user
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<User>> GetAll();

        /// <summary>
        /// Gets a media entity by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<User> GetById(string id);

        /// <summary>
        /// Gets a media entity by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<User> GetByEmail(string email);

        /// <summary>
        /// Creates a new media entity
        /// </summary>
        /// <param name="mediaEntity"></param>
        /// <returns></returns>
        Task<User> Create(User user);

        /// <summary>
        /// Deletes a media entity by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> Delete(string id);

        /// <summary>
        /// Updates a media entity
        /// </summary>
        /// <param name="mediaEntity"></param>
        /// <returns></returns>
        Task<User> Update(User user);
    }
}
