    IEnumerator scorewk()
    {
        scoret.gameObject.SetActive(true);
        while (playing)
        {
            yield return new WaitForSeconds(0.2f);
            score++;
            scoret.text = score.ToString();
        }
    }

    IEnumerator progresswk()
    {
        Destroy(scoret);
        float progress = 0;
        float addby = 1f / (time*5);
        Debug.Log("aby" + addby);
        while (playing && progress != 1)
        {
            yield return new WaitForSeconds(0.2f);
            progress += addby;
            progslider.GetComponent<Slider>().value = progress;
        }
    }
