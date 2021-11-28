using _57Blocks.Music.DataModels.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _57Blocks.Music.BLogic.Contracts
{
    interface IMediaAplicationService<T> where T : MediaEntity
    {
        /// <summary>
        /// Gets all the media entities
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAll();

        /// <summary>
        /// Gets a media entity by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetById(string id);

        /// <summary>
        /// Creates a new media entity
        /// </summary>
        /// <param name="mediaEntity"></param>
        /// <returns></returns>
        Task<T> Create(T mediaEntity);
        
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
        Task<T> Update(T mediaEntity);
    }
}
