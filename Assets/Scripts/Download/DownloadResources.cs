using System.Collections;
using UnityEngine;

namespace Download
{
    public class DownloadResources : MonoBehaviour
    {
        [SerializeField] private SetDownloadedResources _setDownloadedResources;

        private string imageURL = "https://user74522.clients-cdnnow.ru/static/uploads/mrk6440mark.png";
        private string modelURL = "https://user74522.clients-cdnnow.ru/static/uploads/mrk6564obj.glb";

        IEnumerator Start()
        {
            // Загрузка изображения
            WWW wwwImage = new WWW(imageURL);
            yield return wwwImage;

            // Проверка на ошибки загрузки изображения
            if (!string.IsNullOrEmpty(wwwImage.error))
            {
                Debug.Log("Ошибка загрузки изображения: " + wwwImage.error);
            }
            else
            {
                // Изображение успешно загружено
                Texture2D texture = wwwImage.texture;
                _setDownloadedResources.ImageA.texture = texture; // Устанавливаем текстуру в компонент RawImage
                Debug.Log("Текстура загружена!");
            }

            // Загрузка 3D модели
            WWW wwwModel = new WWW(modelURL);
            yield return wwwModel;

            // Проверка на ошибки загрузки 3D модели
            if (!string.IsNullOrEmpty(wwwModel.error))
            {
                Debug.Log("Ошибка загрузки 3D модели: " + wwwModel.error);
            }
            else
            {
                // 3D модель успешно загружена
                byte[] modelData = wwwModel.bytes;
                Debug.Log("3D модель загружена!");
            }
        }
    }
}