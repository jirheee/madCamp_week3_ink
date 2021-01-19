# MadCamp Week3 InkMan
------------
## 1. 프로젝트 개요
매드캠프 3주차 자유주제 프로젝트. 유니티를 이용해서 개발한 2D 플랫포머 게임이다.

## 2. 게임 스토리 및 캐릭터 설정
### 스토리
1안: 안녕 나는 정인이가 그려준 잉크맨!!!!!
정인이가 낙서를 했다
낙서가 살아났다 -> 잉크맨
잉크맨이 자기가 노트속에 살고있다는 것을 깨달았다.
탈출하려고 하는데, 주인이 방해함
그래서 주인을 물리치고 공책을 탈출해야함

### 캐릭터 설정

#### 잉크맨
![캡처](https://user-images.githubusercontent.com/65358599/105020260-6a47a900-5a8a-11eb-9dd1-d07c4900048b.PNG)

#### 정인
![KakaoTalk_20210117_170357455_11-removebg-preview](https://user-images.githubusercontent.com/65358599/105025187-5d2db880-5a90-11eb-9841-a5463d307751.png| width=100)

## 3. 게임 방법 및 시스템

### 게임 목표 
각각의 스테이지에서 잉크맨을 도와 스테이지를 클리어하고, 보스 스테이지에서 잉크맨의 탈출을 방해하는 정인이를 물리쳐 잉크맨을 탈출시키자!

### 조작법
![gif_animation_001-min](https://user-images.githubusercontent.com/65358599/105023478-59009b80-5a8e-11eb-8de5-fe19e2fec7bc.gif)
D, →: 우측 이동  
A, ←: 좌측 이동  
SpaceBar: 점프  
Shift: 슬로우 모드  

### 슬로우 모드
Shift를 이용해서 슬로우 모드에 진입하게 되면, 화면상의 모든 물체들이 회색으로 변하면서 슬로우 모션으로 움직이게 된다.

### 그림 그리기
![gif_animation_007-min](https://user-images.githubusercontent.com/65358599/105023531-6ae23e80-5a8e-11eb-8a40-bc59d454346f.gif)
슬로우 모드에서 좌클릭 후 드래그를 통해 물체를 그릴 수 있다. 드래그를 이용해 그려진 물체는 강체이며 잉크맨을 비롯해 게임 속 대부분의 요소들과 물리적으로 상호작용 할 수 있다.  
  
물체는 항상 닫힌 도형으로만 그릴 수 있으며, 닫힌 도형으로 그리지 않을 경우 시작점과 끝점을 강제로 이어서 닫힌 도형으로 만들어진다.  
  
그림을 그릴 때 마다 잉크통에 존재하는 잉크가 소모되며, 잉크를 모두 소모할 경우 더 이상 그림을 그리지 못한다.  
  
### 그림 지우기
유저가 그린 그림은 우클릭을 통해 삭제할 수 있다.
