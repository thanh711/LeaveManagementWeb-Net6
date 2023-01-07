using LeaveManagement.Data;
using LeaveManagement.Common.Models;
using LeaveManagement.Application.Repositories;

namespace LeaveManagement.Application.Contracts
{
    public interface ILeaveRequestRepository: IGenericRepository<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);
        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();
        Task<LeaveRequestVM> GetLeaveRequestAsync(int? id);
        Task<List<LeaveRequest>> GetAllAsyn(string employeeId);

        Task ChangeApprovalStatus(int leaveRequestID,bool approved);
        Task CancelLeaveRequesr(int leaveRequestID);
        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequest();
    }
}
