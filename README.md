# [2019-2020] 고의적 메모리 노출 게임
<p align="center">
<img src="https://user-images.githubusercontent.com/48519031/156916013-33fc73ea-db34-4c12-b9e9-3c5f7e8796c4.gif" width=120%/>
</p>

<a href="https://drive.google.com/file/d/1ST8TqhS9lM3WXK8dsLTVX_bi7Y_V9H30/view?usp=sharing">배포버전 다운로드</a>

## Description
- 교내 해킹 동아리에서 개인 프로젝트로 게임 메모리 해킹 관련 연구를 진행하였다.
- 시중의 해킹툴을 라이브 게임에 실험하는 것은 윤리적 그리고 법률적 문제가 있을 것이라 판단하여 직접 작은 게임을 개발했다.

## Environment
- Windows OS의 Visual Studio 2019 사용
- FadeIn -> Main -> Close
- C# / WinForm

## Prerequisite

## Files
- FadeIn
	- 프로그램 실행 시, FadeIn이 먼저 실행된다. 게임의 시작 전 준비 단계로, 타이틀 로고가 보여진다.
	```c#
	private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }
	
	private void fadein_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Start();
        }
	
	private void timer1_Tick_1(object sender, EventArgs e)
        {
            double x = 0.05;
            if (this.Opacity <= 0.95) {this.Opacity += x}
            else if (this.Opacity + x > 0.95)
            {
                timer1.Stop();
                Delay(2200);
                this.Close();
            }
        }
	
	```

## Solution
- 게임을 직접 해보면 알겠지만, 이 게임은 정상적인 플레이만으로는 승리할 수 없다.
- 시간이 갈수록 딜레이 시간이 길어져 제한시간 내 20번의 버튼을 클릭할 수 없기 때문이다.
- 내가 의도한 풀이는 게임 내 메모리를 조작하여 승리하는 것이다.
- 나의 경우 <a href="https://www.cheatengine.org/">Cheat Engine</a>을 사용하였다.
<p align="center">
<img src="https://user-images.githubusercontent.com/48519031/156916079-d6a5bf33-33dd-4f28-88b2-1253012e2688.gif" width=120%/>
</p>
- 즉, 메모리 해킹으로 특정 변수값을 원하는 대로 변조할 수 있어야 풀이가 가능하다. 이 프로젝트의 이름을 As I Want(내가 원하는대로)로 정한 이유이다.
	

## Etc
- 이러한 메모리 해킹을 방어하기 위해서 Fake Value를 주입하여 해킹을 사전에 방지할 수 있다.
- 2022년 현재, 고려대학교 정보보호 대학원에 입학한 같은 학과 <a href="https://geun-yeong.tistory.com/">동기</a>에게 이 게임을 풀어보라고 했었다.<br>그는 내가 의도한 풀이와는 다르게 C# 코드 내 사용한 time 관련 함수를 이용했다.<br>그가 직접 내 파일을 뜯어본 결과, 딜레이에 사용되는 타이머는 게임 내 자체적 시간 계산을 하는 것이 아닌 Windows OS의 시간을 가져와 계산하는 것임을 알아냈다.<br>따라서 버튼을 클릭 후 딜레이가 걸렸을 때 Windows의 시간을 미래로 당겨 딜레이를 해제시키는 방법으로 문제를 풀었었다.

