using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Common.Scene
{
    public static class SceneManager
    {
        private static readonly Dictionary<SceneType, string> typeToStringDic = new Dictionary<SceneType, string>();   //씬타입 string 변환 저장해 놓는 Dictionary

        /// <summary>
        /// 씬 로드 함수
        /// </summary>
        public static void LoadScene(SceneType type)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(GetSceneName(type));
        }

        /// <summary>
        /// 씬 이름 반환해주는 함수
        /// </summary>
        private static string GetSceneName(SceneType type)
        {
            if (!typeToStringDic.TryGetValue(type, out string name))
            {
                name = type.ToString();
                typeToStringDic[type] = name;
            }

            return name;
        }
    }
}
