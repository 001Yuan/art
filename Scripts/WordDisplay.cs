using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public GameObject wordWindow; // 文字信息显示窗口
    public Text words; // 要显示内容的文本
    
    private string[] messages = { "《十五朵向日葵》描绘的是一些插在花瓶里的向日葵，呈现出令人心弦震荡的灿烂辉煌。从画面上看，金黄色的向日葵，浓重跳跃，似乎带着燃烧的激情。画家在表现希望和阳光的同时，依旧表达了这希望与阳光溜走的无情。从形式上分析：1、构图上，花朵的分布、大小、聚散、长短、方向结合的恰到好处。该图只有一盆向日葵，且葵花的面积最大，表明向日葵是作者的表现主题，是整幅画的视觉中心和主体物。并且花盆的中轴线也是整幅画竖向的中轴线。整幅画也只有一个台面和立面。2、该图中，那黄色和棕色调的色彩以及技法表现出充满希望和阳光的美丽世界，他以重涂的笔触施色，好似雕塑般般在浮雕上拍上一块黏土。",
    "作为表现性的后印象主义画家梵高的作品，这幅画有很强的笔触。油画中的主色调蓝色代表不开心、阴沉的感觉。很粗的笔触代表忧愁。画中景象是一个望出窗外的景象。画中的树是柏树，但画得像黑色火舌一般，直上云端，令人有不安之感。天空的纹理像涡状星系，并伴随众多星点，而月亮则是以昏黄的月蚀形式出现。整幅画中，底部的村落是以平直、粗短的线条绘画，表现出一种宁静；但与上部粗犷弯曲的线条却产生强烈的对比，在这种高度夸张变形和强烈视觉对比中体现出了画家躁动不安的情感和迷幻的意象世界。梵高生前非常欣赏日本浮世绘《冨岳三十六景》中的《神奈川冲浪里》，而《星夜》中天空的涡状星云画风被认为参考并融入了《神奈川冲浪里》的元素。",
    "《蒙娜丽莎》代表了达芬奇的最高艺术成就，他创作此画时，在艺术上可谓孜孜以求，把自己对人物典型的审美理想全部倾注于此。画中背景山水幽深苍茫，仿佛梦幻般漂浮不定，人物坐姿优雅高贵，目光神奇专注，面颊柔润微红，神情美丽诚挚，含蓄隐约地微笑着。这幅肖像继承了希腊古典主义庄重、典雅、均衡、稳定和富有理想化的表现范式，又进一步突破了希腊古典艺术在人本质上的局限，为使后来的艺术更进一步走向现实客观和深层微妙的表现树立了楷模。作为文艺复兴的启蒙作品，它率先冲破了把人都画成木乃伊一般的传统表现手法，赋予了人物以生命的活力和人性的光彩，《蒙娜丽莎》成为世界上最著名、最使人难以忘怀的一副肖像画。",
    "自画像，是凡高生活与创作、人生与艺术旅程的真实记录。“我想强调的是，同一个人有多样的自画像。与其追求照相般的相似性，不如深入地发掘相似处。”从1880年献身绘画艺术到1890年自杀身亡，凡高短暂的10年艺术生涯里,以其强烈的创作欲望和超人的勤奋刻苦，创作了近2000余幅作品，其中就有40余幅自画像。凡高以年均4幅自画像的频率，真实记载其绘画技法的变迁和思想情感的波动。我们沿着自画像系列作品的脉络，就可以把握凡高艺术生涯的轨迹。"}; // 介绍文字数组列表
                                                                                                                                                                                                                                                                                                           // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // 冲鼠标落点发出射线
        RaycastHit hit;

        if (Input.GetMouseButton(0)) // 按下鼠标左键
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.transform.tag == "T") // 碰撞到标签为T的画框
                {
                    // int.Parse强转整形
                    words.text = messages[int.Parse(hit.transform.name)];
                    wordWindow.SetActive(true);

                }

            }

        }
       if(Input .GetKeyDown(KeyCode.P))
        {
            wordWindow.SetActive(false);
        }
    }
    

}
