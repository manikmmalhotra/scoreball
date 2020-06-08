using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;

public class admanager : MonoBehaviour
{
    private string storeid = "3603765";
    private static string videoAd = "video";

    private void Start()
    {
        Monetization.Initialize(storeid, false);
    }

    public static void VideoAd()
    {
        if (Monetization.IsReady(videoAd))
        {

            ShowAdPlacementContent ad = null;
            ad = Monetization.GetPlacementContent(videoAd) as ShowAdPlacementContent;
            if (ad != null)
            {

                ad.Show();
            }
        }
    }

}
