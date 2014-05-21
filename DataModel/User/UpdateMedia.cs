namespace ZabbixApi.DataModel.User
{
    public class UpdateMedia
    {
        /// <summary>
        /// </summary>
        /// <param name="medias">Media to replace existing media. If a media has the mediaid property defined it will be updated, otherwise a new media will be created.</param>
        /// <param name="users">Users to update. The users must have the userid property defined.</param>
        public UpdateMedia(Media.Media[] medias, User[] users)
        {
            this.medias = medias;
            this.users = users;
        }

        /// <summary>
        /// Media to replace existing media. If a media has the mediaid property defined it will be updated, otherwise a new media will be created.
        /// </summary>
        public Media.Media[] medias;

        /// <summary>
        /// Users to update. The users must have the userid property defined.
        /// </summary>
        public User[] users;
    }
}