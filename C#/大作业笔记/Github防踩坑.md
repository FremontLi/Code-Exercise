### Github使用教程

* [Shell命令行上传文件教程](https://blog.csdn.net/jackson23333/article/details/81315474)  
  使用命令行将本地代码上传到github
* [Github代理设置教程](https://blog.csdn.net/dta0502/article/details/90215089)  
  我们会发现直接在github上clone代码的速度非常慢，网上搜索的操作都不是很靠谱。需要挂VPN，并且进行如上代理设置才能够提高clone的速度。  
  这里贴上不太稳定的vpn仅供参考（需要人民币）：[vpn1](www.chaorenssr.tech)
* [GithubDesktop教程](https://www.zhihu.com/question/278431031/answer/486857507)

------------

### 一些问题：

### 1. Github进行fork后如何与原仓库同步？

#### 最省事的办法可能是（不建议）：  

* 在你fork的仓库setting页翻到最下方，然后delete这个仓库  
* 然后重新 fork 人家仓库，并 git clone 到你的本地。  

#### 比较好的方法：

* [同步原仓库教程](https://cloud.tencent.com/developer/article/1398502)
* 按照上面教程操作之后，本地主分支已经和remote同步，但是要把本地自己的分支也同步还需要点击GitHub desktop菜单栏branch-update from master