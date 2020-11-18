using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Desktop_Facebook
{

    public class PublishAndReactions
    {
        public int m_TotalLikes { get; set; }

        public int m_NumOfPhotos { get; set; }

        public List<string> m_PictureOrTextHandeler;

        public PublishAndReactions(int i_NumOfPhotos, int i_TotalLikes)
        {
            m_NumOfPhotos = i_NumOfPhotos;
            m_TotalLikes = i_TotalLikes;
            m_PictureOrTextHandeler = new List<string>();
        }
    }
}
