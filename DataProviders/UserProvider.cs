using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.User;

namespace ZabbixApi.DataProviders
{
    internal sealed class UserProvider : DataProvider
    {
        public UserProvider(ZabbixClient client) : base(client) { }

        public string[] AddMedia(Create request)
        {
            var response = base.SendRequest<UserIds>("user.create", request);
            return response.userids;
        }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<UserIds>("user.create", request);
            return response.userids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<UserIds>("user.delete", request);
            return response.userids;
        }

        public string[] DeleteMedia(Delete request)
        {
            var response = base.SendRequest<DataModel.Media.MediaIds>("user.deletemedia", request);
            return response.mediaids;
        }

        public User[] Get(Get request)
        {
            var response = base.SendRequest<User[]>("user.get", request);
            return response;
        }

        public string[] IsReadable(IsReadable request)
        {
            var response = base.SendRequest<UserIds>("user.isreadable", request);
            return response.userids;
        }

        public string[] IsWritable(IsWritable request)
        {
            var response = base.SendRequest<UserIds>("user.iswritable", request);
            return response.userids;
        }

        public LoginResponse Login(Login request)
        {
            var response = base.SendRequest<LoginResponse>("user.login", request);
            return response;
        }

        public bool Logout(string[] request)
        {
            var response = base.SendRequest<bool>("user.logout", request);
            return response;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<UserIds>("user.update", request);
            return response.userids;
        }

        public string[] UpdateMedia(UpdateMedia request)
        {
            var response = base.SendRequest<UserIds>("user.updatemedia", request);
            return response.userids;
        }

        public string[] UpdateProfile(UpdateProfile request)
        {
            var response = base.SendRequest<UserIds>("user.updateprofile", request);
            return response.userids;
        }
    }
}