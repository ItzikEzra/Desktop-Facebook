using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Desktop_Facebook
{
   public class BestTimeToUpload
    {
        public readonly FacebookManager m_FacebookManager = FacebookManager.Instance;
        public static readonly BestTimeToUpload sr_Best= new BestTimeToUpload();

        public BestTimeToUpload()
        {

        }

        public List<PublishAndReactions> createTimeList()
        {
            List<PublishAndReactions> listOfPhotosLikeByTime = new List<PublishAndReactions>();
            for (int i = 0; i < 24; i++)
            {
                listOfPhotosLikeByTime.Add(new PublishAndReactions(0, 0));
            }
            return listOfPhotosLikeByTime;
        }

        public int FindBestTimeToUploadAPicture(List<string> io_Pictures)
        {
            FacebookObjectCollection<Album> albums;
            albums = this.m_FacebookManager.m_LoggedInUser.Albums;
            float maxLikePerPhoto = 0, likesPerPost;
            int bestHourToPost = 0, hour = 0;

            List<PublishAndReactions> listOfPhotosLikeByTime = createTimeList();
           
            foreach (Album album in albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    listOfPhotosLikeByTime[photo.CreatedTime.Value.Hour].m_NumOfPhotos += 1;
                    listOfPhotosLikeByTime[photo.CreatedTime.Value.Hour].m_TotalLikes += photo.LikedBy.Count;
                    listOfPhotosLikeByTime[photo.CreatedTime.Value.Hour].m_PictureOrTextHandeler.Add(photo.PictureNormalURL);
                }
            }

            foreach (PublishAndReactions photosAndLikes in listOfPhotosLikeByTime)
            {
                if (photosAndLikes.m_NumOfPhotos != 0)
                {
                    likesPerPost = photosAndLikes.m_TotalLikes / photosAndLikes.m_NumOfPhotos;
                }
                else
                {
                    likesPerPost = 0;
                }

                if (maxLikePerPhoto < likesPerPost)
                {
                    io_Pictures = photosAndLikes.m_PictureOrTextHandeler;
                    maxLikePerPhoto = likesPerPost;
                    bestHourToPost = hour;
                }

                hour += 1;
            }

            return bestHourToPost;
        }

        public int FindBestTimeToUploadAPost(List<string> io_Pictures)
        {
            FacebookObjectCollection<Album> albums = m_FacebookManager.m_LoggedInUser.Albums;
            float maxLikePerPost = 0, likesPerPhoto;
            int bestHourToPhoto = 0, hour = 0;

            List<PublishAndReactions> listOfPostsLikeByTime = createTimeList();

            foreach (Post post in m_FacebookManager.m_LoggedInUser.Posts)
            {
                   listOfPostsLikeByTime[post.CreatedTime.Value.Hour].m_NumOfPhotos += 1;
                   listOfPostsLikeByTime[post.CreatedTime.Value.Hour].m_TotalLikes += post.Comments.Count;
                   listOfPostsLikeByTime[post.CreatedTime.Value.Hour].m_PictureOrTextHandeler.Add(post.Caption);
            }

            foreach (PublishAndReactions photosAndLikes in listOfPostsLikeByTime)
            {
                if (photosAndLikes.m_NumOfPhotos != 0)
                {
                    likesPerPhoto = photosAndLikes.m_TotalLikes / photosAndLikes.m_NumOfPhotos;
                }
                else
                {
                    likesPerPhoto = 0;
                }

                if (maxLikePerPost < likesPerPhoto)
                {
                    io_Pictures = photosAndLikes.m_PictureOrTextHandeler;
                    maxLikePerPost = likesPerPhoto;
                    bestHourToPhoto = hour;
                }

                hour += 1;
            }

            return bestHourToPhoto;
        }
    }
}
