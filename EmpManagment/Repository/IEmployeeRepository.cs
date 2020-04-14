// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IEmployeeRepository.cs" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// ----------------------------------------------------------------------------------------------------------------------

namespace Repository
{
    using Model;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Declare Interface in Repository Project.
    /// </summary>
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Declare GetAll Methods.
        /// </summary>
        /// <returns>AllEmployee.</returns>
        IEnumerable<Employee> GetAll();

        /// <summary>
        /// Declare Get Method.
        /// </summary>
        /// <param name="id">id.</param>
        /// <returns>Employee.</returns>
        Employee Get(long id);

        /// <summary>
        /// Declare Post Method.
        /// </summary>
        /// <param name="entity">entity.</param>
        /// <returns>Task.</returns>
        Task<int> Add(Employee entity);

        /// <summary>
        /// Declare Put method.
        /// </summary>
        /// <param name="dbEntity">dbEntity.</param>
        /// <param name="entity">entity.</param>
        void Update(Employee dbEntity, Employee entity);

        /// <summary>
        /// DEclare Delete method.
        /// </summary>
        /// <param name="entity">entity.</param>
        void Delete(Employee entity);
    }
}
