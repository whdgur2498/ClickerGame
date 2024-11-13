using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Common.Scene
{
    public static class SceneManager
    {
        private static readonly Dictionary<SceneType, string> typeToStringDic = new Dictionary<SceneType, string>();   //��Ÿ�� string ��ȯ ������ ���� Dictionary

        /// <summary>
        /// �� �ε� �Լ�
        /// </summary>
        public static void LoadScene(SceneType type)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(GetSceneName(type));
        }

        /// <summary>
        /// �� �̸� ��ȯ���ִ� �Լ�
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
