# [2019-2020] 고의적 메모리 노출 게임
<p align="center">
<img src="https://user-images.githubusercontent.com/48519031/156916013-33fc73ea-db34-4c12-b9e9-3c5f7e8796c4.gif" width=120%/>
</p>

<a href="https://drive.google.com/file/d/1ST8TqhS9lM3WXK8dsLTVX_bi7Y_V9H30/view?usp=sharing">배포버전 다운로드</a>

## Description
- 2020년 ~ 2021년, 게임 프로듀서로 기획한 Virtual League 명칭의 게임 홍보 및 포트폴리오 용도 목적의 개발
- WEB 개발에 대한 지식과 경험 전무로, 많은 시행착오가 존재
- <a href="https://html5up.net/">HTML5 UP</a> 템플릿 활용

## Environment
- Windows OS의 Visual Studio Code 사용
- Client -> Gabia Hosting Server -> Github IO
- HTML / CSS / JS

## Prerequisite

## Files
- index.html

## Solution
- 게임을 직접 해보면 알겠지만, 이 게임은 정상적인 플레이만으로는 승리할 수 없다.
- 시간이 갈수록 딜레이 시간이 길어져 제한시간 내 20번의 버튼을 클릭할 수 없기 때문이다.
- 내가 의도한 풀이는 게임 내 메모리를 조작하여 승리하는 것이다.
- 나의 경우 Cheat Engine을 사용하였다.
<p align="center">
<img src="https://user-images.githubusercontent.com/48519031/156916079-d6a5bf33-33dd-4f28-88b2-1253012e2688.gif" width=120%/>
</p>
	

## Etc
- 이러한 메모리 해킹을 방어하기 위해서 Fake Value를 주입하여 해킹을 사전에 방지할 수 있다.
- 2022년 현재, 고려대학교 정보보호 대학원에 입학한 같은 학과 <a href="https://geun-yeong.tistory.com/"동기</a>에게 이 게임을 풀어보라고 했었다.<br>그는 내가 의도한 풀이와는 다르게 C# 코드 내 사용한 time 관련 함수를 이용했다.<br>그가 직접 내 파일을 뜯어본 결과, 딜레이에 사용되는 타이머는 게임 내 자체적 시간 계산을 하는 것이 아닌 Windows OS의 시간을 가져와 계산하는 것임을 알아냈다.<br>따라서 버튼을 클릭 후 딜레이가 걸렸을 때 Windows의 시간을 미래로 당겨 딜레이를 해제시키는 방법으로 문제를 풀었었다.

