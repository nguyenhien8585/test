new TikzItem2
{
    Id = 1,
    Title = "Trọng tâm G và tam giác trung điểm",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với trọng tâm G, tam giác trung điểm A'B'C' và các đường trung tuyến AA', BB', CC'.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_1.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=1, line join = round, line cap = round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/B,5/0/C,2/4/A}
\tkzCentroid(A,B,C) \tkzGetPoint{G}
\coordinate (A') at ($(C)!1/2!(B)$);
\coordinate (B') at ($(C)!1/2!(A)$);
\coordinate (C') at ($(A)!1/2!(B)$);
\tkzDrawPolygon(A,B,C)
\tkzDrawPolygon(A',B',C')
\tkzDrawSegments(A,A' B,B' C,C')
\tkzDrawPoints[fill=black](A,B,C,A',B',C',G)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](B,A',C)
\tkzLabelPoints[right](B')
\tkzLabelPoints[left](C')
\node at ($(G)+(0,0.4)$) [right] {$G$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 2,
    Title = "Trọng tâm G và tam giác trung điểm (bản thu nhỏ)",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với trọng tâm G, tam giác trung điểm A'B'C' và các đường trung tuyến, tỷ lệ 0.7.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_2.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.7, line join = round, line cap = round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/B,5/0/C,2/4/A}
\tkzCentroid(A,B,C) \tkzGetPoint{G}
\coordinate (A') at ($(C)!1/2!(B)$);
\coordinate (B') at ($(C)!1/2!(A)$);
\coordinate (C') at ($(A)!1/2!(B)$);
\tkzDrawPolygon(A,B,C)
\tkzDrawPolygon(A',B',C')
\tkzDrawSegments(A,A' B,B' C,C')
\tkzDrawPoints[fill=black](A,B,C,A',B',C',G)
\tkzLabelPoints[above,font=\footnotesize](A)
\tkzLabelPoints[below,font=\footnotesize](B,A',C)
\tkzLabelPoints[right,font=\footnotesize](B')
\tkzLabelPoints[left,font=\footnotesize](C')
\node at ($(G)+(0,0.4)$) [right] {$G$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 3,
    Title = "Tam giác vuông và tam giác đều ACD",
    Category = "Hình tam giác",
    Description = "Tam giác ABC vuông tại B và tam giác đều ACD dựng trên cạnh AC, có các cung tròn minh họa phép quay.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_3.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\pgfmathsetmacro\x{4*sqrt(3)/3}
\tkzDefPoints{0/0/B,4/0/C,0/\x/A}
\tkzDefEquilateral(A,C)\tkzGetPoint{D}
\tkzDrawPolygon(A,B,C)
\tkzDrawPolygon(A,D,C)
\coordinate (K) at ($(A)!0.5!(C)$);
\tkzDrawPoints[size=5,fill=black](A,B,C,D,K)
\tkzLabelPoints[below](B,C)
\tkzLabelPoints[right](K)
\tkzDrawSegments(K,D)
\tkzLabelPoints[above](A,D)
\tikzset{compass style/.append style={-stealth,dashed,very thick}}
\tkzDrawArc[towards,arrows=-stealth](A,B)(K)
\tkzDrawArc[towards,arrows=-stealth](A,C)(D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 4,
    Title = "Các tam giác đều dựng trên cạnh AC",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với tam giác đều BEC và BFC dựng bên ngoài, M và N là trung điểm AF và EC.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_4.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round]
\tkzInit[xmin=-4,xmax=8,ymin=-1,ymax=8]
\tkzDefPoints{-2/0/A,0/0/B,4/0/C}
\tkzDefPointBy[rotation= center B angle 60](C)\tkzGetPoint{F}
\tkzDefPointBy[rotation= center B angle -60](A)\tkzGetPoint{E}
\tkzDefMidPoint(E,C)\tkzGetPoint{N}
\tkzDefMidPoint(A,F)\tkzGetPoint{M}
\tkzDrawPoints(A,B,C,E,F,M,N)
\tkzLabelPoint[above](E){$E$}
\tkzLabelPoint[above](F){$F$}
\tkzLabelPoint[above](M){$M$}
\tkzLabelPoint[above](N){$N$}
\tkzLabelPoint[below](A){$A$}
\tkzLabelPoint[below](B){$B$}
\tkzLabelPoint[below](C){$C$}
\tkzDrawSegments(A,C A,F A,E C,E C,F B,E B,M B,N B,F M,N) 
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 5,
    Title = "Trọng tâm G, tâm ngoại tiếp O, trực tâm H",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với trọng tâm G, tâm ngoại tiếp O, trực tâm H, tam giác trung điểm A'B'C' và các đường đặc biệt.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_5.png",
    Code = @"\begin{tikzpicture}
\tkzInit[xmin=-1,xmax=6,ymin=-1,ymax=4]
\tkzClip
\tkzDefPoints{0/0/B,1/3/A, 5/0/C}
\tkzCentroid(A,B,C)\tkzGetPoint{G}
\tkzCircumCenter(A,B,C)\tkzGetPoint{O}
\coordinate (a) at ($(B)!(A)!(C)$);
\draw (A)--(a);

%\tkzDrawAltitude(B,C)(A)\tkzGetPoint{a}
\tkzDefLine[perpendicular=through B](A,C)\tkzGetPoint{b}
\tkzInterLL(A,a)(B,b)\tkzGetPoint{H}
\tkzInterLL(A,G)(B,C)\tkzGetPoint{M}
\tkzInterLL(A,O)(B,C)\tkzGetPoint{N}
\tkzDefMidPoint(B,C)\tkzGetPoint{A'}
\tkzDefMidPoint(A,B)\tkzGetPoint{C'}
\tkzDefMidPoint(A,C)\tkzGetPoint{B'}
%\coordinate[label=above right:$K$] (K) at ($(S)!(A)!(M)$);
%\tkzDrawAltitude(B',C')(A')
\tkzDrawPoints(A,B,C,G,O,H,A',B',C')
\tkzDrawSegments(A,B B,C C,A A,M A,N A',B' A',C' B',C')
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](G,C')
\tkzLabelPoints[right](O,B',H)
\tkzLabelPoints[below](A',B,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 6,
    Title = "Tam giác với trọng tâm G và trung tuyến",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với trọng tâm G, các trung điểm M, N, P và tam giác trung điểm MNP.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_6.png",
    Code = @"\begin{tikzpicture}[scale=0.6,line join=round, font=\scriptsize,line cap=round,>=stealth]
\tkzDefPoints{2/4/A, 0/0/B, 6/0/C}
\tkzDefMidPoint(A,B) \tkzGetPoint{P}
\tkzDefMidPoint(A,C) \tkzGetPoint{N}
\tkzDefMidPoint(B,C) \tkzGetPoint{M}
\tkzInterLL(A,M)(B,N) \tkzGetPoint{G}
\tkzDrawPoints(A,B,C,P,M,N,G)
\tkzDrawSegments(A,B B,C C,A A,M B,N C,P M,N N,P P,M)
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](B,P)
\tkzLabelPoints[right](N,C)
\tkzLabelPoints[below](M)
\node at (2.8,1.7) {G};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 7,
    Title = "Tam giác vuông và tam giác đều (không cung tròn)",
    Category = "Hình tam giác",
    Description = "Tam giác ABC vuông tại B và tam giác đều ACD dựng trên cạnh AC, K là trung điểm AC.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_7.png",
    Code = @"\begin{tikzpicture}[scale=0.7, line join=round, line cap=round]
\pgfmathsetmacro\x{4*sqrt(3)/3}
\tkzDefPoints{0/0/B,4/0/C,0/\x/A}
\tkzDefEquilateral(A,C)\tkzGetPoint{D}
\tkzDrawPolygon(A,B,C)
\tkzDrawPolygon(A,D,C)
\coordinate (K) at ($(A)!0.5!(C)$);
\tkzDrawPoints[size=5,fill=black](A,B,C,D,K)
\tkzLabelPoints[below](B,C)
\tkzLabelPoints[right](K)
\tkzDrawSegments(K,D)
\tkzLabelPoints[above](A,D)
%\tikzset{compass style/.append style={-stealth,dashed,very thick}}
%\tkzDrawArc[towards,arrows=-stealth](A,B)(K)
%\tkzDrawArc[towards,arrows=-stealth](A,C)(D)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 8,
    Title = "Các tam giác đều và đường thẳng MN",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với tam giác đều BEC và BFC, M và N là trung điểm AF và EC, đường thẳng MN.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_8.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round]
\tkzInit[xmin=-4,xmax=8,ymin=-1,ymax=8]
\tkzDefPoints{-2/0/A,0/0/B,4/0/C}
\tkzDefPointBy[rotation= center B angle 60](C)\tkzGetPoint{F}
\tkzDefPointBy[rotation= center B angle -60](A)\tkzGetPoint{E}
\tkzDefMidPoint(E,C)\tkzGetPoint{N}
\tkzDefMidPoint(A,F)\tkzGetPoint{M}
\tkzDrawPoints(A,B,C,E,F,M,N)
\tkzLabelPoint[above](E){$E$}
\tkzLabelPoint[above](F){$F$}
\tkzLabelPoint[above](M){$M$}
\tkzLabelPoint[above](N){$N$}
\tkzLabelPoint[below](A){$A$}
\tkzLabelPoint[below](B){$B$}
\tkzLabelPoint[below](C){$C$}
\tkzDrawSegments(A,C A,F A,E C,E C,F B,E B,M B,N B,F M,N) 
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 9,
    Title = "Tam giác với đường cao và trung tuyến",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với đường cao AH, trung tuyến AM, M là trung điểm BC, H là chân đường cao, góc BAC.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_9.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/B,1/3/A,5/0/C,2.5/0/M, 1/0/H}
\tkzDrawSegments(A,B B,C A,C A,M A,H)
\tkzDrawPoints[size=5,fill=black](A,B,C,M,H)
\tkzLabelPoints[below](B,C,M,H)
\tkzLabelPoints[above](A)
\tkzMarkRightAngle[size=0.2](A,H,C)
\tkzMarkAngles[size=0.5,arc=ll](B,A,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 10,
    Title = "Tam giác đều với trọng tâm G",
    Category = "Hình tam giác",
    Description = "Tam giác đều ABC với trọng tâm G, đường cao AM vuông góc với BC tại M, M là trung điểm BC.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_10.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/B,4/0/C,2/0/M}
\tkzDefEquilateral(B,C)\tkzGetPoint{A}
\tkzCentroid(A,B,C)\tkzGetPoint{G}
\tkzDrawSegments(A,B B,C A,C A,M)
\tkzDrawPoints[size=5,fill=black](A,B,C,M,G)
\tkzLabelPoints[below](B,C,M)
\tkzLabelPoints[above](A)
\tkzLabelPoints[right](G)
\tkzMarkRightAngle[size=0.25](A,M,C)
\tkzMarkSegments[mark=||](M,B M,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 11,
    Title = "Tam giác vuông tại A với đường cao và trung tuyến",
    Category = "Hình tam giác",
    Description = "Tam giác ABC vuông tại A, có đường cao AH và trung tuyến AM, M là trung điểm BC, H là chân đường cao.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_11.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/B,1/2/A,5/0/C,2.5/0/M, 1/0/H}
\tkzDrawSegments(A,B B,C A,C A,M A,H)
\tkzDrawPoints[size=5,fill=black](A,B,C,M,H)
\tkzLabelPoints[below](B,C,M,H)
\tkzLabelPoints[above](A)
\tkzMarkRightAngle[size=0.2](B,A,C)
\tkzMarkRightAngle[size=0.2](A,H,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 12,
    Title = "Tam giác và tam giác trung điểm với đánh dấu",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với tam giác trung điểm MNP, đánh dấu các cặp cạnh bằng nhau: AP=PB, BM=MC, AN=NC.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_12.png",
    Code = @"\begin{tikzpicture}%hình 1
\clip (-0.5,-0.5) rectangle (3.5,2);
\tkzDefPoints{0/0/A, 3/0/B, 2/1.5/C}
\coordinate (M) at ($(B)!0.5!(C)$);
\coordinate (N) at ($(A)!0.5!(C)$);
\coordinate (P) at ($(A)!0.5!(B)$);
\tkzDrawPolygon(A,B,C)%vẽ đa giác
\tkzDrawPolygon(M,N,P)
\tkzMarkSegments[mark=|](A,P B,P)%đánh dấu đoạn thẳng
\tkzMarkSegments[mark=||](B,M C,M)
\tkzMarkSegments[mark=x](A,N C,N)
\tkzDrawPoints(A,B,C,M,N,P)
%\tkzDrawSegments(A,M H,E M,F) %vẽ các đoạn
\tkzLabelPoints[left](A,N)%viết tên các điểm
\tkzLabelPoints[right](B,M)%viết tên các điểm
\tkzLabelPoints[above](C)
\tkzLabelPoints[below](P)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 13,
    Title = "Đường tròn tâm I và dây cung AB",
    Category = "Hình tam giác",
    Description = "Đường tròn tâm I bán kính 2cm, dây cung AB song song với tiếp tuyến d, IH vuông góc với AB tại H.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_13.png",
    Code = @"\begin{tikzpicture}
\tkzInit[xmin=-2.1,ymin=-2,xmax=2.2,ymax=2]
\tkzClip
\tkzDefPoint(0,0){I}
\tkzDefPoints{-2/1/u,2/1/v,0/1/H}
\draw (-2,1)--(2,1);
\draw (u) node[above]{$d$};
\draw (I) circle[radius=2cm];
\tkzInterLC[R](u,v)(I,2 cm)
\tkzGetPoints{A}{B}
\tkzDrawPoints(A,B,H,I)
\tkzLabelPoints[below](A,I)
\tkzLabelPoints[above right](B)
\tkzLabelPoints[above](H)
\tkzDrawSegments(I,H I,A I,B)
\tkzMarkRightAngles(I,H,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 14,
    Title = "Đường tròn tâm I và dây cung vuông góc",
    Category = "Hình tam giác",
    Description = "Đường tròn tâm I bán kính 2cm, dây cung AB vuông góc với bán kính IH tại điểm H trong đường tròn.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_14.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round]
\tkzDefPoint(0,0){I}
\def\r{2}
\tkzDefShiftPoint[I](-90:0.6*\r){H}
\tkzDefShiftPoint[I](0:\r){i}
\tkzDefLine[orthogonal=through H](I,H)\tkzGetPoint{h}
%\tkzDrawSegments(H,h)
\tkzInterLC(H,h)(I,i)\tkzGetPoints{A}{B}
\tkzDrawSegments(I,A A,B I,H I,B)
\tkzDrawPoints[size=1pt,fill=black](I,A,B,H)
\draw (I) circle[radius=\r cm];
\tkzMarkRightAngles(A,H,I)
\tkzLabelPoints[above](I)
\tkzLabelPoints[below](A,H,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 15,
    Title = "Tam giác và đường phân giác trong",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với điểm D trên cạnh AC, đường BD và AI, I là giao điểm của BD và AC.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_15.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,>=stealth,x=1.0cm,y=1.0cm]
\draw (0.0,-0.0)-- (1.0,3.0)-- (4.0,0.0)-- (0.0,-0.0)-- (2.321,1.678);
\draw (1.0,3.0)-- (1.606,0.0);
\begin{scriptsize}
\draw [fill=black] (0.0,-0.0) circle (1pt) node[left] {$A$};
\draw [fill=black] (1.0,3.0) circle (1pt) node[left] {$B$};
\draw [fill=black] (4.0,0.0) circle (1pt) node[above] {$C$};
\draw [fill=black] (2.321,1.678) circle (1pt) node[above] {$D$};
\draw [fill=black] (1.401,1.013) circle (1.5pt) node[right] {$I$};
\end{scriptsize}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 16,
    Title = "Tam giác với đường trung bình",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với M, P là trung điểm AB và AC, đường trung bình MP song song BC, các đường thẳng d₁, d₂.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_16.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\clip (-1,-1) rectangle (7,6);
%%%%%%%%%%%%%%%
\tkzDefPoints{0/0/B,2/4.5/A,6/0/C,3/4/F}
\coordinate (M) at ($(A)!0.5!(B)$);
\coordinate (P) at ($(A)!0.5!(C)$);
\coordinate (N) at ($(C)!0.5!(B)$);
\tkzDrawSegments(M,P)
\tkzInterLL(N,F)(M,P)\tkzGetPoint{I}
\tkzDrawPoints[size=5,fill=black](A,B,C,M,N,P)
\tkzDrawPolygon(A,B,C)
\tkzLabelPoints[above](A)
\tkzLabelPoints[right](C)
\tkzLabelPoints[left](B)
%\tkzLabelPoints[below](N)
\tkzLabelPoints[above left](M)
%\tkzLabelPoints[above right](P)
%\tkzMarkRightAngles[size=0.2](C,N,F P,I,F)
\tkzDrawLines[add=0.1 and 0.3](M,P)
\tkzLabelLine[pos=1.3,right](M,P){$d_1$}
%\tkzDrawLines[add=0.0 and 0.2](B,K)
%\tkzLabelLine[pos=-0.1,right](B,K){$d_1$}
\tkzDrawLines[add=0.1 and 0.2](M,N)
\tkzLabelLine[pos=1.3,right](M,N){$d_2$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 17,
    Title = "Tam giác với đường vuông góc từ N",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với M, P, N là trung điểm, NF vuông góc với MP tại I, CN vuông góc với BC tại N.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_17.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\clip (-1,-1) rectangle (7,6);
%%%%%%%%%%%%%%%
\tkzDefPoints{0/0/B,2/4.5/A,6/0/C,3/4/F}
\coordinate (M) at ($(A)!0.5!(B)$);
\coordinate (P) at ($(A)!0.5!(C)$);
\coordinate (N) at ($(C)!0.5!(B)$);
\tkzDrawSegments(M,P N,F)
\tkzInterLL(N,F)(M,P)\tkzGetPoint{I}
\tkzDrawPoints[size=5,fill=black](A,B,C,M,N,P)
\tkzDrawPolygon(A,B,C)
\tkzLabelPoints[above](A)
\tkzLabelPoints[right](C)
\tkzLabelPoints[left](B)
\tkzLabelPoints[below](N)
\tkzLabelPoints[above left](M)
\tkzLabelPoints[above right](P)
\tkzMarkRightAngles[size=0.2](C,N,F P,I,F)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 18,
    Title = "Tam giác với hai đường cao vuông góc",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với đường cao từ A cắt đường thẳng d₂ từ C tại M, đường cao từ A cắt đường thẳng d₁ từ B tại N.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_18.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\clip (-1,-1) rectangle (7,6);
%%%%%%%%%%%%%%%
\tkzDefPoints{-0.5/0/B,2/5/A,6.5/0/C}
%\tkzDrawBisector(A,C)(B)
%\tkzDrawBisector(B,C)(A)
\coordinate (H) at ($(A)!0.5!(B)$);
\coordinate (K) at ($(A)!0.4!(C)$);
\coordinate (A_1) at ($(B)!0.11!(C)$);
\coordinate (A_2) at ($(B)!0.71!(C)$);
\tkzInterLL(A,A_1)(C,H)\tkzGetPoint{M}
\tkzInterLL(A,A_2)(B,K)\tkzGetPoint{N}
\tkzDrawSegments(C,H B,K A,A_1 A,A_2)
\tkzDrawPoints[size=5,fill=black](A,B,C,H,K,A_1,A_2)
\tkzDrawPolygon(A,B,C)
\tkzLabelPoints[above](A)
\tkzLabelPoints[right](C)
\tkzLabelPoints[left](B)
\tkzLabelPoints[below](A_1,A_2)
\tkzMarkRightAngles[size=0.2](C,M,A K,N,A)
\tkzDrawLines[add=0.0 and 0.2](C,H)
\tkzDrawLines[add=0.0 and 0.2](B,K)
\tkzLabelLine[pos=1.2,right](B,K){$d_1$}
\tkzLabelLine[pos=1.2,left](C,H){$d_2$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 19,
    Title = "Tam giác với trọng tâm G và trung tuyến",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với trọng tâm G, M là trung điểm BC, C' và B' là trung điểm AB và AC, CC' và BB' cắt nhau tại G.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_19.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\clip (-1,-1) rectangle (7,6);
%%%%%%%%%%%%%%%
\tkzDefPoints{0/0/B,2/4.5/A,6/0/C}
\coordinate (C') at ($(A)!0.5!(B)$);
\coordinate (B') at ($(A)!0.5!(C)$);
\coordinate (M) at ($(C)!0.5!(B)$);
\tkzInterLL(C,C')(B,B')\tkzGetPoint{G}
\tkzDrawSegments(C,C' B,B')
\tkzDrawPoints[size=5,fill=black](A,B,C,C',B',G,M)
\tkzDrawPolygon(A,B,C)
\tkzLabelPoints[above](A,G)
\tkzLabelPoints[right](C)
\tkzLabelPoints[left](B)
\tkzLabelPoints[below](M)
\tkzLabelPoints[above left](C')
\tkzLabelPoints[above right](B')
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 20,
    Title = "Tam giác ABC với ba trung điểm",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với ba trung điểm a, b, c của các cạnh BC, AC và AB.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_20.png",
    Code = @"\begin{tikzpicture}[scale=0.7,font=\footnotesize,line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/B,1/2/A,4/0/C}
\tkzDrawPoints[fill=black](A,B,C)
\tkzDefMidPoint(A,B) \tkzGetPoint{c}
\tkzDefMidPoint(C,B) \tkzGetPoint{a}
\tkzDefMidPoint(A,C) \tkzGetPoint{b}
\tkzDrawPolygon(A,B,C)
\tkzLabelPoints[above](A) 
\tkzLabelPoints[below](B,C,a)
\tkzLabelPoints[left](c)
\tkzLabelPoints[right](b)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 21,
    Title = "Tam giác với đường cao và trung tuyến (d₁, d₂)",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với M là trung điểm AB, đường cao BH vuông góc AC, trung tuyến CM, hai đường thẳng d₁ và d₂.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_21.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\clip (-1,-1) rectangle (7,6);
%%%%%%%%%%%%%%%
\tkzDefPoints{0/0/B,2/4.5/A,6/0/C}
\coordinate (M) at ($(A)!0.5!(B)$);
\tkzDefPointBy[projection=onto A--C](B)\tkzGetPoint{H}
\tkzDrawSegments(C,M B,H)
\tkzDrawPoints[size=5,fill=black](A,B,C,M)
\tkzDrawPolygon(A,B,C)
\tkzLabelPoints[above](A)
\tkzLabelPoints[right](C)
\tkzLabelPoints[left](B)
\tkzMarkRightAngles[size=0.2](B,H,C)
\tkzDrawLines[add=0.0 and 0.3](B,H)
\tkzLabelLine[pos=1.3,right](B,H){$d_1$}
\tkzDrawLines[add=0.0 and 0.3](C,M)
\tkzLabelLine[pos=1.2,above](C,M){$d_2$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 22,
    Title = "Tam giác với hai đường cao d₁ và d₂",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với hai đường cao: CH vuông góc AB (d₂) và BK vuông góc AC (d₁), H và K là chân đường cao.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_22.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\clip (-1,-1) rectangle (7,6);
%%%%%%%%%%%%%%%
\tkzDefPoints{0/0/B,2/5/A,5/0/C}
\tkzDefPointBy[projection=onto A--B](C)\tkzGetPoint{H}
\tkzDefPointBy[projection=onto A--C](B)\tkzGetPoint{K}
\tkzDrawSegments(C,H B,K)
\tkzDrawPoints[size=5,fill=black](A,B,C,H,K)
\tkzDrawPolygon(A,B,C)
\tkzLabelPoints[above](A)
\tkzLabelPoints[right](C)
\tkzLabelPoints[left](B)
\tkzMarkRightAngles[size=0.2](B,K,C B,H,C)
%\tkzLabelPoint[above left](H){$d_2$}
%\tkzLabelPoint[above right](K){$d_1$}
\tkzDrawLines[add=0.0 and 0.2](C,H)
\tkzDrawLines[add=0.0 and 0.2](B,K)
\tkzLabelLine[pos=1.2,right](B,K){$d_1$}
\tkzLabelLine[pos=1.2,left](C,H){$d_2$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 23,
    Title = "Tam giác với trọng tâm G và trung tuyến (lặp lại)",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với trọng tâm G, M là trung điểm BC, trung tuyến CC' và BB' cắt nhau tại G.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_23.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\clip (-1,-1) rectangle (7,6);
%%%%%%%%%%%%%%%
\tkzDefPoints{0/0/B,2/4.5/A,6/0/C}
\coordinate (C') at ($(A)!0.5!(B)$);
\coordinate (B') at ($(A)!0.5!(C)$);
\coordinate (M) at ($(C)!0.5!(B)$);
\tkzInterLL(C,C')(B,B')\tkzGetPoint{G}
\tkzDrawSegments(C,C' B,B')
\tkzDrawPoints[size=5,fill=black](A,B,C,C',B',G,M)
\tkzDrawPolygon(A,B,C)
\tkzLabelPoints[above](A,G)
\tkzLabelPoints[right](C)
\tkzLabelPoints[left](B)
\tkzLabelPoints[below](M)
\tkzLabelPoints[above left](C')
\tkzLabelPoints[above right](B')
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 24,
    Title = "Tam giác với ba đường cao",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với ba đường cao: AK vuông góc BC, CE vuông góc AB, BF vuông góc AC.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_24.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/B,3/0/C,1/2/A}
\tkzDefPointBy[projection=onto C--B](A)\tkzGetPoint{K}
\tkzDefPointBy[projection=onto A--B](C)\tkzGetPoint{E}
\tkzDefPointBy[projection=onto C--A](B)\tkzGetPoint{F}
\pgfresetboundingbox
\tkzDrawPolygon(A,B,C)
\tkzDrawSegments(A,K C,E B,F)
\tkzLabelPoints[below](B,C,K)
\tkzLabelPoints[above](A)
\tkzLabelPoints[right](F)
\tkzLabelPoints[left](E)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 25,
    Title = "Tam giác với ba đường cao và trực tâm H",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với ba đường cao cắt nhau tại trực tâm H: AK, CE, BF vuông góc với các cạnh tương ứng.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_25.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/B,3/0/C,1/2/A}
\tkzDefPointBy[projection=onto C--B](A)\tkzGetPoint{K}
\tkzDefPointBy[projection=onto A--B](C)\tkzGetPoint{E}
\tkzDefPointBy[projection=onto C--A](B)\tkzGetPoint{F}
\tkzInterLL(A,K)(C,E)\tkzGetPoint{H} 
\pgfresetboundingbox
\tkzDrawPolygon(A,B,C)
\tkzDrawSegments(A,K C,E B,F)
\tkzLabelPoints[below](B,C,K)
\tkzLabelPoints[below right](H)
\tkzLabelPoints[above](A)
\tkzLabelPoints[right](F)
\tkzLabelPoints[left](E)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 26,
    Title = "Tam giác với ba trung tuyến",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với ba trung tuyến: AM (M là trung điểm BC), CN (N là trung điểm AB), BP (P là trung điểm AC).",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_26.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/B,4/0/C,1/2/A}
\coordinate (M) at ($(C)!0.5!(B)$);
\coordinate (N) at ($(A)!0.5!(B)$);
\coordinate (P) at ($(A)!0.5!(C)$);
\tkzDrawPolygon(A,B,C)
\tkzDrawSegments(A,M C,N B,P)
\tkzLabelPoints[below](B,C,M)
\tkzLabelPoints[above](A)
\tkzLabelPoints[right](P)
\tkzLabelPoints[left](N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 27,
    Title = "Tam giác với tam giác trung điểm MNP",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với tam giác trung điểm MNP, trong đó M, N, P là trung điểm của BC, AC, AB.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_27.png",
    Code = @"\begin{tikzpicture}[scale=0.6]
\tkzInit[xmin=-3,xmax=3,ymin=-3,ymax=1]
\tkzDefPoints{0/0/A, -2/-3/B,2/-3/C}
\tkzDefMidPoint(A,C)
\tkzGetPoint{N}
\tkzDefMidPoint(A,B)
\tkzGetPoint{P}
\tkzDefMidPoint(B,C)
\tkzGetPoint{M}
\tkzLabelPoints[left](B, P)
\tkzLabelPoints[right](C,N)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](M)
\tkzDrawSegments(A,B B,C C,A P,M M,N)
\tkzDrawPoints(A,B,C,M,N,P)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 28,
    Title = "Tam giác với trung tuyến AM",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với trung tuyến AM (M là trung điểm BC) và N là trung điểm AB.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_28.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round, >=stealth]
\coordinate (A) at (0,0);
\coordinate (B) at (-1.5,-2);
\coordinate (C) at (3,-2);
\coordinate (M) at ($(B)!0.5!(C)$);
\coordinate (N) at ($(A)!0.5!(B)$);
\tkzDrawSegments(A,B B,C C,A A,M)
\tkzLabelPoints[below](C)
\tkzLabelPoints[below](B)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](M)
\tkzLabelPoints[left](N)
\tkzDrawPoints[fill=black](A,B,C,M,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 29,
    Title = "Tam giác với đường trung bình MN",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với M, N là trung điểm AB và AC, K là trung điểm MN, đường trung tuyến AK.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_29.png",
    Code = @"\begin{tikzpicture}[scale=1]
\tkzDefPoints{0/0/B, 1/4/A,5/0/C}
\tkzDefMidPoint(A,B) \tkzGetPoint{M}
\tkzDefMidPoint(A,C) \tkzGetPoint{N}
\tkzDefMidPoint(M,N) \tkzGetPoint{K}
\tkzDrawSegments(A,B B,C A,C M,N A,K)
\tkzDrawPoints[fill=black](A,B,C,M,N,K)
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](M,B)
\tkzLabelPoints[below](K)
\tkzLabelPoints[right](N,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 30,
    Title = "Tam giác đều với đường cao AH",
    Category = "Hình tam giác",
    Description = "Tam giác đều ABC với đường cao AH, H là trung điểm BC.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_30.png",
    Code = @"\begin{tikzpicture}[scale=1,>=stealth, line join=round, line cap=round]
\tkzDefPoints{0/0/C,4/0/B}
\tkzDefEquilateral(C,B)\tkzGetPoint{A}
\coordinate (H) at ($(C)!0.5!(B)$);
\tkzDrawPoints[fill=black](A,B,C,H)
\tkzDrawSegments(A,H A,B A,C B,C)
\tkzLabelPoints[below](B)
\tkzLabelPoints[below right](H)
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 31,
    Title = "Tam giác với trọng tâm G và đường cao",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với trọng tâm G, đường cao AH vuông góc BC, trung tuyến AF (F là trung điểm BC), GI vuông góc BC.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_31.png",
    Code = @"\begin{tikzpicture}[scale=0.9, line join=round, line cap=round]
\tkzDefPoints{1.2/3.5/A,0/0/B,5/0/C}
\tkzCentroid(A,C,B)\tkzGetPoint{G}
\tkzDefPointBy[projection=onto C--B](A)\tkzGetPoint{a}
\coordinate (F) at ($(C)!0.5!(B)$);
\coordinate (E) at ($(A)!1/2!(C)$);
\coordinate (M) at ($(B)!0.8!(C)$);
\tkzInterLL(A,F)(B,E)\tkzGetPoint{G}
\tkzDefPointBy[projection=onto C--B](G)\tkzGetPoint{i}
\tkzInterLL(A,a)(B,C)\tkzGetPoint{H}
\tkzInterLL(G,i)(B,C)\tkzGetPoint{I}
\tkzDrawPolygon(A,C,B)
\tkzDrawSegments(A,F A,H G,I)
\tkzDrawPoints[fill=black](A,C,B,F,G,H,I,M)
\tkzLabelPoints[below](C,F,B,H,I,M)
\tkzLabelPoints[above](A)
%\tkzLabelPoints[above left](E)
\tkzLabelPoints[above right](G)
\tkzMarkRightAngle[size=0.2](A,H,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 32,
    Title = "Tam giác đều với trung tuyến AM",
    Category = "Hình tam giác",
    Description = "Tam giác đều ABC với trung tuyến AM, M là trung điểm BC, vector AM màu xanh.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_32.png",
    Code = @"\begin{tikzpicture}[>=stealth,line cap=round,line join=round,scale=.6,font=\footnotesize]
\tkzDefPoints{-2/-3/B,4/-3/C}
\tkzDefPointBy[rotation = center B angle 60](C) \tkzGetPoint{A}
\coordinate (M) at ($(C)!0.5!(B)$);
\tkzCentroid(A,B,C) \tkzGetPoint{G}
\tkzDrawPolygon(A,B,C)
\tkzDrawPoints[fill=black](A,B,C,M)
\draw[blue,->](A)--(M);
\tkzLabelPoints[left](B)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](M)
\tkzLabelPoints[right](C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 33,
    Title = "Tam giác với đường trung bình MN",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với M, N là trung điểm AB và AC, đường trung bình MN song song với BC.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_33.png",
    Code = @"\begin{tikzpicture}[scale=1,font=\footnotesize,line join=round, line cap=round,>=stealth]
\tkzDefPoints{2/3/A,0/0/B,5/0/C}
\tkzDefMidPoint(A,B)\tkzGetPoint{M}
\tkzDefMidPoint(A,C)\tkzGetPoint{N}
\tkzDrawPoints[fill=black](A,B,C,N,M)
\tkzDrawSegments(M,N)
\tkzDrawPolygon(A,B,C)
\tkzLabelPoints[left](B,M)
\tkzLabelPoints[above](A)
\tkzLabelPoints[right](C,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 34,
    Title = "Tam giác đều với trọng tâm G và vector AG",
    Category = "Hình tam giác",
    Description = "Tam giác đều ABC với trọng tâm G, I là trung điểm BC, đoạn GI, vector AG màu xanh.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_34.png",
    Code = @"\begin{tikzpicture}[>=stealth,line cap=round,line join=round,scale=.6,font=\footnotesize]
\tkzDefPoints{-2/-3/B,4/-3/C}
\tkzDefPointBy[rotation = center B angle 60](C) \tkzGetPoint{A}
\coordinate (I) at ($(C)!0.5!(B)$);
\tkzCentroid(A,B,C) \tkzGetPoint{G}
\tkzDrawPolygon(A,B,C)
\tkzDrawPoints[fill=black](A,B,C,I,G)
\tkzDrawSegments(G,I)
\draw[blue,->](A)--(G);
\tkzLabelPoints[left](G,B)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](I)
\tkzLabelPoints[right](C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 35,
    Title = "Tam giác với đường trung tuyến BD",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với D là trung điểm AC (AD=DC), đường trung tuyến BD, K là trọng tâm tam giác DBC.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_35.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\clip (-2.5,-0.5) rectangle (5,4.5);
\tkzDefPoints{-2/0/A,4/0/B,0/3/C}
\coordinate (D) at ($(A)!0.5!(C)$);
\tkzCentroid(D,B,C)\tkzGetPoint{K}
\tkzDrawPoints[size=5,fill=black](A,B,C,D,K)
\tkzLabelPoints[below](A,B)
\tkzLabelPoints[above](C)
\tkzLabelPoints[above left](D,K)
\tkzDrawSegments(B,D)
\tkzDrawPolygon(A,B,C)
\tkzMarkSegments[mark=||](A,D D,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 36,
    Title = "Tam giác với đường thẳng song song qua M",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với M trên cạnh BC, đường thẳng qua M song song với AC cắt AB tại N.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_36.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[xmin=-0.5, xmax=4, ymin=-0.5, ymax=4.5]
\tkzClip
\tkzDefPoints{0/0/B,2.5/0/M,3.5/0/C,2/4/A}
\tkzDefLine[parallel=through M](A,C)\tkzGetPoint{m}
\tkzInterLL(A,B)(M,m)\tkzGetPoint{N}
\tkzDrawPoints[fill=black](A,B,C,M,N)
\tkzDrawSegments(A,B B,C C,A A,M M,N)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](B,M,C)
\tkzLabelPoints[above left](N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 37,
    Title = "Lục giác đều với tam giác trung điểm",
    Category = "Hình tam giác",
    Description = "Lục giác đều ABCDEF với tam giác trung điểm MNP, trong đó M, N, P là trung điểm của AB, CD, EF.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_37.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round,fill=black, >=stealth]%[fill=black,scale=0.7]
\coordinate (A) at (-1,3);
\coordinate (B) at (1,3);
\coordinate (C) at (3,0);
\coordinate (D) at (2,-2);
\coordinate (E) at (-1,-2);
\coordinate (F) at (-3,0);
\coordinate (M) at ($(A)!0.5!(B)$);
\coordinate (N) at ($(C)!0.5!(D)$);
\coordinate (P) at ($(E)!0.5!(F)$);
\tkzLabelPoints[below](D,E)
\tkzLabelPoints[above](A,B,M)
\tkzLabelPoints[left=0.1](F,P)
\tkzLabelPoints[right](C,N)
\tkzDrawSegments(A,B B,C C,D D,E E,F F,A M,N N,P P,M)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 38,
    Title = "Tam giác với đoạn nối hai trung điểm",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với M, N là trung điểm AB và AC, đoạn thẳng MN nối hai trung điểm.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_38.png",
    Code = @"\begin{tikzpicture}[scale=0.8, line join=round, line cap=round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{1/2/A,0/0/B,3/0/C}
\coordinate (M) at ($(A)!0.5!(B)$);
\coordinate (N) at ($(A)!0.5!(C)$);
\tkzDrawSegments(A,B B,C C,A M,N)
\tkzDrawPoints[size=5,fill=black](A,B,C,M,N)
\tkzLabelPoints[left](B,M)
\tkzLabelPoints[above](A)
\tkzLabelPoints[right](N,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 39,
    Title = "Tam giác với đường trung tuyến BD (lặp lại)",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với D là trung điểm AC (AD=DC), đường trung tuyến BD, K là trọng tâm tam giác DBC.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_39.png",
    Code = @"\begin{tikzpicture}[scale=0.8, line join=round, line cap=round]
%\clip (-2.5,-0.5) rectangle (5,4.5);
\tkzDefPoints{-2/0/A,4/0/B,0/3/C}
\coordinate (D) at ($(A)!0.5!(C)$);
\tkzCentroid(D,B,C)\tkzGetPoint{K}
\tkzDrawPoints[size=5,fill=black](A,B,C,D,K)
\tkzLabelPoints[below](A,B)
\tkzLabelPoints[above](C)
\tkzLabelPoints[above left](D,K)
\tkzDrawSegments(B,D)
\tkzDrawPolygon(A,B,C)
\tkzMarkSegments[mark=||](A,D D,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 40,
    Title = "Tam giác với trọng tâm G và điểm đối xứng I",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với M là trung điểm BC, G là trọng tâm, I là điểm đối xứng của B qua G, đường BI và AM.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_40.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round,fill=black, >=stealth]%[fill=black]
\coordinate (A) at (0,0);
\coordinate (B) at (2,3);
\coordinate (C) at (5,0);
\coordinate (M) at ($(B)!0.5!(C)$);
\coordinate (G) at ($(A)!0.66!(M)$);
\coordinate (I) at ($2*(G)-(B)$);
\tkzLabelPoints[above](B)
\tkzLabelPoints[below](A,C,I)
\tkzLabelPoints[right](M,G)
\tkzDrawPoints(A,B,C,M,I,G)
\tkzDrawSegments (A,B B,C C,A B,I A,M)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 41,
    Title = "Tam giác với tỷ số đồng dạng",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với M là trung điểm AB, N trên AC sao cho AN/AC=1/3, K là trung điểm MN, D là trung điểm BC.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_41.png",
    Code = @"\begin{tikzpicture}[scale=0.8]
\tkzDefPoints{3/5/A,1/0/B,7/0/C}
\tkzDefMidPoint(B,A)\tkzGetPoint{M}
\tkzDefPointBy[homothety = center A ratio 0.33](C)\tkzGetPoint{N}
\tkzDefMidPoint(M,N)\tkzGetPoint{K}
\tkzDefMidPoint(B,C)\tkzGetPoint{D}
\tkzDrawSegments(A,B B,C C,A A,K K,D M,N)
\tkzDrawPoints(A,B,C,N,M,K,D)
\tkzLabelPoints[left](B,M)
\tkzLabelPoints[right](N,C)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below right](K)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 42,
    Title = "Tam giác với phép vị tự",
    Category = "Hình tam giác",
    Description = "Tam giác SAB với C là điểm trên AB sao cho AC/AB=1/3, phép vị tự tâm A tỷ số 1/3.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_42.png",
    Code = @"\begin{tikzpicture}[scale=0.8]
\tkzDefPoints{0/0/A,5/0/B,3/4/S}
\tkzDefPointBy[homothety = center A ratio 0.33](B)\tkzGetPoint{C}
\tkzDrawSegments(S,A A,B B,S S,C)
\tkzDrawPoints(A,B,C,S)
\tkzLabelPoints[above](S)
\tkzLabelPoints[below](A,B,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 43,
    Title = "Tam giác với phép tịnh tiến",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với M là trung điểm AB, D, E, F là các điểm liên quan đến phép tịnh tiến và tỷ số trên cạnh.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_43.png",
    Code = @"\begin{tikzpicture}
\tkzDefPoints{0/0/B,5/0/C,2/4/A}
\coordinate (M) at ($(A)!0.5!(B)$);
\coordinate (D) at ($(B)!-2!(C)$);
\coordinate (F) at ($(A)!{2/5}!(C)$);
\coordinate (E) at ($(M)+(B)-(C)$);
\tkzDrawSegments(A,B C,D A,C A,D D,F E,M)
\tkzDrawPoints(A,B,C,M,D,E,F)
\tkzLabelPoints[above left](E,M)
\tkzLabelPoints[above right](F)
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](D)
\tkzLabelPoints[below left](B)
\tkzLabelPoints[below right](C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 44,
    Title = "Tam giác với phép vị tự tỷ số 4 và 3",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với M là trung điểm BC, D và E là các điểm thỏa BD=4BA và AE=3AC, đường AM.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_44.png",
    Code = @"\begin{tikzpicture}[scale=.7, font=\footnotesize, line join=round, line cap=round, >=stealth]
\coordinate (A) at (0,0);
\coordinate (B) at (-.5,-1);
\coordinate (C) at (1.5,-1);
\coordinate (M) at ($(B)!.5!(C)$);
\coordinate (D) at ($(B)!4!(A)$);
\coordinate (E) at ($(A)!3!(C)$);
\draw (B)--(D)--(E)--(A)--(M) (B)--(C);
\foreach \p/\pos in {A/above left, B/below, C/below, D/above, M/below, E/below}
\fill (\p) circle (1pt) node[\pos] {$\p$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 45,
    Title = "Hai tam giác đối xứng tâm",
    Category = "Hình tam giác",
    Description = "Tam giác ABC và A'B'C' đối xứng qua các tâm A, B, C tương ứng, tạo thành hai tam giác liên kết.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_45.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[xmin=-0.5, xmax=4.5, ymin=-0.5, ymax=3.5]
\tkzClip
\tkzDefPoints{1.5/1/A,3/1/B,2/2/C}
\tkzDefPointBy[symmetry=center A](B)\tkzGetPoint{A'}
\tkzDefPointBy[symmetry=center B](C)\tkzGetPoint{B'}
\tkzDefPointBy[symmetry=center C](A)\tkzGetPoint{C'}
\tkzDrawPoints[fill=black](A,B,C,A',B',C')
\tkzDrawSegments(A',B B',C C',A A',B' B',C' C',A')
\tkzLabelPoints[below](B,A',B')
\tkzLabelPoints[above](C')
\tkzLabelPoints[right](C)
\tkzLabelPoints[above left](A)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 46,
    Title = "Tam giác với điểm I và trọng tâm G",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với M là trung điểm BC, N là trung điểm AC, I trên AC sao cho AI/AC=3/4, G là trọng tâm.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_46.png",
    Code = @"\begin{tikzpicture}
\coordinate[label=left:$B$] (B) at (0,0);
\coordinate[label=right:$C$] (C) at (4,0);
\coordinate[label=above:$A$] (A) at (1,2);
\coordinate[label=below:$M$] (M) at ($(C)!.5!(B)$ );
\coordinate[label=below:$N$] (N) at ($(C)!.5!(A)$ );
\coordinate[label=above right:$I$] (I) at ($(A)!3/4!(C)$ );
\coordinate[label=below:$G$] (G) at ($(A)!2/3!(M)$ );
\draw (B)--(N) (I)--(M);
\draw (A)--(B)--(C)--cycle;
\fill (A)circle(1.5pt) (B)circle(1.5pt) (C)circle(1.5pt) (I)circle(1.5pt) (M)circle(1.5pt) (G)circle(1.5pt) (N)circle(1.5pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 47,
    Title = "Tam giác với nhiều đường nét đứt",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với trọng tâm G, M là trung điểm BC, N là trung điểm AC, các đường nét đứt AJ, AI, AM, BN.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_47.png",
    Code = @"\begin{tikzpicture}[scale=0.7, line join = round, line cap = round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/J,2/0/B,7/0/C,3/5/A,4/0/I}
\coordinate (M) at ($(B)!0.5!(C)$);
\coordinate (N) at ($(A)!0.5!(C)$);
\tkzCentroid(A,B,C) \tkzGetPoint{G}
\tkzDrawSegments(A,B A,C J,C)
\tkzDrawSegments[dashed](A,J A,I A,M B,N)
\tkzDrawPoints[fill=black](A,B,C,I,J,M,G)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](J,B,I,C,M)
\tkzLabelPoints[below right](G)
%\tkzLabelPoints[right](C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 48,
    Title = "Tam giác và hình ảnh phóng to",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với hình ảnh phóng to DEF (tỷ số 2), M và N là trung điểm, G là trọng tâm, I và K liên quan đến phép vị tự.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_48.png",
    Code = @"\begin{tikzpicture}[scale=.7, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tikzset{label style/.style={font=\footnotesize}}
\coordinate (B) at (0,0);
\coordinate (A) at (1,3);
\coordinate (C) at (4,0);
\coordinate (D) at ($(A)!2!(B)$);
\coordinate (E) at ($(B)!2!(C)$);
\coordinate (F) at ($(C)!2!(A)$);
\coordinate (M) at ($(B)!1/2!(C)$);
\coordinate (N) at ($(E)!1/2!(F)$);
\tkzInterLL(A,M)(D,N) \tkzGetPoint{G}
\coordinate (I) at ($(G)!1/2!(A)$);
\coordinate (K) at ($(G)!1/2!(D)$);
\tkzDrawSegments(A,D B,E F,C D,E E,F G,A N,D M,N M,K N,I A,N I,K)
\tkzDrawPoints[fill=black](M,A,B,C,N,E,F,G,D,I,K)
\tkzLabelPoints[above](A,N)
\tkzLabelPoints[below](D,C,M)
\tkzLabelPoints[left](F,G,I,K,B)
\tkzLabelPoints[right](E)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 49,
    Title = "Tam giác với trọng tâm và phép vị tự",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với trọng tâm G, M là trung điểm BC, E và F là điểm liên quan phép vị tự tâm G tỷ số 3.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_49.png",
    Code = @"\begin{tikzpicture}[scale=.8, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tikzset{label style/.style={font=\footnotesize}}
\coordinate (B) at (0,0);
\coordinate (A) at (1,3);
\coordinate (C) at (4,0);
\coordinate (E) at (-2,2);
\coordinate (M) at ($(B)!1/2!(C)$);
\coordinate (G) at ($(A)!2/3!(M)$);
\coordinate (F) at ($3*(G)-(E)-(A)$);
\tkzDrawSegments(A,B B,C A,C A,M A,E A,F E,F B,E F,C E,C)
\tkzDrawPoints[fill=black](M,A,B,C,G,E,F)
\tkzLabelPoints[above](A,E)
\tkzLabelPoints[below](B,M,F)
\tkzLabelPoints[left](G)
\tkzLabelPoints[right](C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 50,
    Title = "Tam giác với các trung điểm và trọng tâm",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với trọng tâm G, M là trung điểm BC, N là trung điểm AC, E và F trên BC, P là trung điểm AF.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_50.png",
    Code = @"\begin{tikzpicture}[scale=0.7]
\tkzDefPoints{0/0/B, 6/0/C, 1.5/0/E, 4.5/0/F, 4/3/A}
\tkzDefMidPoint(B,C)\tkzGetPoint{M}
\tkzDefMidPoint(A,C)\tkzGetPoint{N}
\tkzDefMidPoint(A,F)\tkzGetPoint{P}
\tkzCentroid(A,B,C)\tkzGetPoint{G}
\tkzDrawPoints[fill=black](A,B,C,E,F,G)
\tkzDrawPolygon(A,B,C)
\tkzDrawSegments(A,E A,F A,M B,N E,P)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](B,C,E,F)
\tkzLabelPoints[below right](G)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 51,
    Title = "Tam giác ABC với ba trung điểm M, N, K",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với M là trung điểm AB, N là trung điểm AC, K là trung điểm BC.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_51.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/A,1/2/B,4/0/C}
\coordinate (M) at ($(A)!0.5!(B)$);
\coordinate (N) at ($(C)!0.5!(A)$);
\coordinate (K) at ($(B)!0.5!(C)$);
\tkzDrawSegments(A,B B,C C,A)
\tkzDrawPoints[size=5,fill=black](A,B,C,M,N,K)
\tkzLabelPoints[below, font=\footnotesize](A,N,C)
\tkzLabelPoints[above, font=\footnotesize](B)
\tkzLabelPoints[above left, font=\footnotesize](M)
\tkzLabelPoints[above right, font=\footnotesize](K)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 52,
    Title = "Tam giác với tam giác trung điểm MNK",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với tam giác trung điểm MNK, trong đó M, N, K là trung điểm của AB, AC, BC.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_52.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/A,1/2/B,4/0/C}
\coordinate (M) at ($(A)!0.5!(B)$);
\coordinate (N) at ($(C)!0.5!(A)$);
\coordinate (K) at ($(B)!0.5!(C)$);
\tkzDrawSegments(A,B B,C C,A M,N N,K M,K)
\tkzDrawPoints[size=5,fill=black](A,B,C,M,N,K)
\tkzLabelPoints[below, font=\footnotesize](A,N,C)
\tkzLabelPoints[above, font=\footnotesize](B)
\tkzLabelPoints[above left, font=\footnotesize](M)
\tkzLabelPoints[above right, font=\footnotesize](K)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 53,
    Title = "Tam giác với điểm đối xứng B' qua G",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với trọng tâm G, I là trung điểm BC, B' là điểm đối xứng của B qua G, đường AI và BB'.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_53.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/B,4/0/C, 1/2/A}
\coordinate (I) at ($(C)!0.5!(B)$);
\tkzCentroid(A,B,C)\tkzGetPoint{G}
\coordinate (B') at ($(A)+(B)-(G)$);
\tkzDrawSegments(A,B B,C C,A B',B A,I)
\tkzDrawPoints[size=5,fill=black](A,B,C,I,G,B')
\tkzLabelPoints[below,font=\footnotesize](B,C,I)
\tkzLabelPoints[above,font=\footnotesize](A,B')
\tkzLabelPoints[below left,font=\footnotesize](G)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 54,
    Title = "Tam giác ABC đơn giản",
    Category = "Hình tam giác",
    Description = "Tam giác ABC đơn giản với ba đỉnh A, B, C.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_54.png",
    Code = @"\begin{tikzpicture}[scale=0.6, line join=round, line cap=round]
\tkzDefPoints{0/0/B,5/0/C,2/2/A}
\tkzDrawSegments(A,B B,C C,A)
\tkzDrawPoints[size=5,fill=black](A,B,C)
\tkzLabelPoints[above](A)
\tkzLabelPoints[below](B,C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 55,
    Title = "Tam giác với ba trung tuyến và trọng tâm G",
    Category = "Hình tam giác",
    Description = "Tam giác ABC với ba trung tuyến AI, CK, BM cắt nhau tại trọng tâm G, trong đó I, K, M là trung điểm của BC, AB, AC.",
    ImagePath = "Hinh_tam_giac/hinhtamgiac_55.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/B,4/0/C,1/2/A}
\coordinate (I) at ($(C)!0.5!(B)$);
\coordinate (K) at ($(A)!0.5!(B)$);
\coordinate (M) at ($(C)!0.5!(A)$);
\tkzInterLL(A,I)(C,K)\tkzGetPoint{G}
\tkzDrawSegments(A,B B,C C,A A,I C,K B,M)
\tkzDrawPoints[size=5,fill=black](A,B,C,I,K,M,G)
\tkzLabelPoints[below](C, B,I)
\tkzLabelPoints[above](A)
\tkzLabelPoints[above right](M)
\tkzLabelPoints[above left](K)
\tkzLabelPoints[above right](G)
\end{tikzpicture}"
},
