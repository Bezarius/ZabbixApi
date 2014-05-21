namespace ZabbixApi.DataModel.User
{
    public class AddMedia
    {
        /// <summary>
        /// </summary>
        /// <param name="medias">Media to create for the given users. The media userid property must not be defined.</param>
        /// <param name="users">Users to add the media to. The users must have the userid property defined.</param>
        public AddMedia(Media.Media[] medias, User[] users)
        {
            this.medias = medias;
            this.users = users;
        }

        /// <summary>
        /// Media to create for the given users. The media userid property must not be defined.
        /// </summary>
        public Media.Media[] medias;

        /// <summary>
        /// Users to add the media to. The users must have the userid property defined.
        /// </summary>
        public User[] users;
    }
}