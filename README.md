# blockOverwatch
말아먹은 팀운빨에 휴식이 필요하신가요?

아니면, 정신병 걸린 약육강식의 세계에서 완전히 벗어나시길 원하시나요?

그런 당신에게 이 프로그램을 추천드립니다!

### 사용 방법
- Microsoft .NET Framework 4.0이 시스템에 설치되어 있는지 확인합니다. 만약 없다면, [여기](https://www.microsoft.com/ko-kr/download/details.aspx?id=17851)에서 설치합니다.
- 우측 Release에 있는 "당신의 인생은 레전드가 아닙니다"를 누르십시오.
- blockOverwatch.exe를 다운로드 받으십시오.
- 다운로드받은 blockOverwatch.exe를 실행하십시오.

원한다면 작업 스케쥴러나 시작프로그램 등록을 통해 Windows 시작과 함께 이 프로그램을 실행시킬 수 있습니다.

### 롤도 하기 싫어요
이 코드를 Form1.vb의 24번째 줄 다음에 추가한 다음 Release로 빌드합니다. (Visual Studio 2010 이상이 필요합니다)
```
            If prog.ProcessName = "League of Legends" Then
                prog.Kill()
            End If
```
