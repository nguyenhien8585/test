
new TikzItem2
{
    Id = 1,
    Title = "Đường tròn tâm I với tiếp tuyến d",
    Category = "Hình tròn",
    Description = "Đường tròn tâm I, tiếp tuyến d, IH vuông góc với d tại H.",
    ImagePath = "Hinh_tron/hinhtron_1.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.9]
\tkzDefPoints{0/0/I}
\draw (I) circle (2 cm);
\draw (-3,-1)--(3,-1) node[above] {$d$} (I)--(0,-1) node[below] {$H$};
\filldraw (I) circle (1pt) node[above] {$I$};
\filldraw (0,-1) circle (1pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 2,
    Title = "Elip với hai tiêu điểm",
    Category = "Hình tròn",
    Description = "Elip tâm O trên hệ trục Oxy, hai tiêu điểm F₁ và F₂, điểm M trên elip, đoạn MF₁ và MF₂ nét đứt.",
    ImagePath = "Hinh_tron/hinhtron_2.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth,font=\footnotesize]
\draw[->] (-2.5,0)--(3,0) node[below]{$x$};
\draw[->] (0,-1.5)--(0,2) node[right]{$y$};
\draw (0,0) node[below left]{$O$};
\tkzDefPoints{0/0/O,-2/0/A_1,2/0/A_2,0/-1/B_1,0/1/B_2,-1.4/0/F_1,1.4/0/F_2}
\draw[color=blue,thick] (O) ellipse (2cm and 1cm);
\coordinate (M) at ($(O)+(60:2cm and 1cm)$);
\tkzDrawPoints[size=5,fill=black](A_1,A_2,B_1,B_2,F_1,F_2,M)
\tkzDrawSegments[dashed](M,F_1 M,F_2)
\tkzLabelPoints[below right,font=\footnotesize](B_1)
\tkzLabelPoints[above right,font=\footnotesize](B_2,A_2,M)
\tkzLabelPoints[below ,font=\footnotesize](F_1,F_2)
\tkzLabelPoints[above left,font=\footnotesize](A_1)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 3,
    Title = "Hai đường tròn trong hình vuông",
    Category = "Hình tròn",
    Description = "Hình vuông ABCD 16×16, hai đường tròn tâm I và J bán kính 8 tô màu xám, IK và JK nét đứt.",
    ImagePath = "Hinh_tron/hinhtron_3.png",
    Code = @"\begin{tikzpicture}[scale=.17]
\tkzDefPoint(0,0){A}
\tkzDefPoint(16,0){B}
\tkzDefPoint(16,16){C}
\tkzDefPoint(0,16){D}
\tkzDefPoint(0,8){I}
\tkzDefPoint(8,0){J}
\tkzDefPoint(10,10){H}
\tkzDefPoint(8,8){K}
\tkzLabelPoints[right](H)
\tkzDrawCircle(I,A)
\tkzDrawCircle[fill=black!20,opacity=.5,draw=none](I,A)
\tkzDrawCircle(J,A)
\tkzDrawSegments[dashed](I,K J,K)
\tkzDrawPoints(A,B,C,D,I,J,K)
\tkzDrawCircle[fill=black!20,opacity=.5,draw=none](J,A)
%\tkzLabelPoint[below](S){\footnotesize $S_1$}
%\tkzLabelPoint[below](S'){\footnotesize $x$}
%\tkzLabelPoint[below](T){\footnotesize $S_2$}
\tkzDrawSegments(A,B B,C C,D D,A)
\tkzLabelSegment[above](C,D){$16$}
\tkzLabelSegment[left](A,I){$8$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 4,
    Title = "Đường tròn ngoại tiếp tam giác với trực tâm",
    Category = "Hình tròn",
    Description = "Đường tròn tâm I ngoại tiếp tam giác ABC, D đối xứng với B qua I, trực tâm H, đường cao AA' và CC'.",
    ImagePath = "Hinh_tron/hinhtron_4.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\clip (-2.5+0.1,-2.5+0.1) rectangle (2.5+0.5,2.5+0.1);
\tkzDefPoints{0/0/I}
\draw (I) circle(2cm);
\coordinate (B) at ($(I)+(-150:2cm)$);
\coordinate (C) at ($(I)+(-30:2cm)$);
\coordinate (A) at ($(I)+(110:2cm)$);
\coordinate (D) at ($(I)!-1!(B)$);
\tkzDefPointBy[projection=onto A--B](C)\tkzGetPoint{C'}
\tkzDefPointBy[projection=onto C--B](A)\tkzGetPoint{A'}
\tkzInterLL(A,A')(C,C')\tkzGetPoint{H}
\tkzDrawPoints[size=5,fill=black](I,B,C,A,D,H)
\tkzDrawPolygon(A,B,C)
\tkzDrawSegments(B,D A,A' C,C')
\tkzLabelPoints[below,font=\footnotesize](B,C)
\tkzLabelPoints[above,font=\footnotesize](A,I)
\tkzLabelPoints[right,font=\footnotesize](D)
\tkzLabelPoints[below left,font=\footnotesize](H)
\end{tikzpicture}"
},

// ❌ TikZ lỗi (Id=5): Command '['pdflatex', '-interaction=nonstopmode', 'E:/cai_dat/NBH Tool/NBH Tool/bin/X64/Release/Images\\Hinh_tron\\hinhtron_5.tex']' returned non-zero exit status 1.

new TikzItem2
{
    Id = 6,
    Title = "Nửa đường tròn với hình thang tô màu",
    Category = "Hình tròn",
    Description = "Nửa đường tròn đường kính AB tâm O, điểm C và D trên cung, hình thang ABCD tô xanh cyan.",
    ImagePath = "Hinh_tron/hinhtron_6.png",
    Code = @"\begin{tikzpicture}[line join = round, line cap = round,>=stealth,font=\footnotesize,scale=1] 
\def\R{2}
\coordinate[label = below:$O$] (O) at (0,0); 
\coordinate (A) at (-\R,0); 
\coordinate (B) at ($(A)!2!(O)$);
\coordinate[label = above right:$C$] (C) at (50:\R); 
\coordinate[label = above left:$D$] (D) at (130:\R);
\coordinate[label = below:$A$] (AA) at ($(A)!(D)!(B)$); 
\coordinate[label = below:$B$] (BB) at ($(A)!(C)!(B)$); 
\draw (A) arc(180:0:\R)--cycle;
\draw[fill=cyan!20] (BB)--(C)--(D)--(AA)--cycle;
\foreach \x in {AA,O,BB} \fill[black] (\x) circle (1.5pt); 
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 7,
    Title = "Đường tròn với dây cung và đường thẳng d",
    Category = "Hình tròn",
    Description = "Đường tròn tâm I, dây cung AB, M là trung điểm AB, IM vuông góc AB, đường thẳng d: x+y-m=0.",
    ImagePath = "Hinh_tron/hinhtron_7.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/I}
\draw (I) circle(2cm);
\coordinate (B) at ($(I)+({2*cos -30},{2*sin -30})$);
\coordinate (A) at ($(I)+({2*cos -150},{2*sin -150})$);
\coordinate (M) at ($(A)!1/2!(B)$);
\draw (A)--(B)--+(0:2cm) node [above] {$d\colon x+y-m=0$} (A)--+(180:1cm);
\tkzDrawPoints[fill=black](I,B,A,M)
\draw (I)--(M) (A)--(I)--(B);
\tkzLabelPoints[below](M)
\tkzLabelPoints[above](I)
\tkzLabelPoints[below right](B)
\tkzLabelPoints[below left](A)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 8,
    Title = "Đường tròn với dây cung và góc vuông",
    Category = "Hình tròn",
    Description = "Đường tròn tâm I bán kính R, dây cung AB cắt đường thẳng Δ, IH vuông góc AB tại H, góc AIB và góc IHA vuông góc.",
    ImagePath = "Hinh_tron/hinhtron_8.png",
    Code = @"\begin{tikzpicture}[scale=0.7, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/I,0/-1/C,1/-1/D}
\draw (I) circle [radius=2];
\tkzInterLC[R](C,D)(I,2cm)
\tkzGetPoints{A}{B}
\tkzDrawLines[add=.3 and 0.1](A,B)
\tkzLabelLine[pos=-.2,above](A,B){$\Delta$}
\coordinate (H) at ($(A)!(I)!(B)$);
\tkzDrawPoints[fill=black](I,A,B,H)
\tkzDrawSegments(I,H I,A I,B)
\tkzLabelSegment[pos=.5,above](I,A){$R$}
\tkzMarkRightAngles[size=0.2](I,H,A A,I,B)
\tkzLabelPoints[above](I)
\tkzLabelPoints[below left](B)
\tkzLabelPoints[below right](A)
\tkzLabelPoints[below](H)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 9,
    Title = "Đường tròn ngoại tiếp tam giác vuông",
    Category = "Hình tròn",
    Description = "Nửa đường tròn tâm I đường kính AB, tam giác vuông ABC với góc vuông tại A, đường cao AH, AE vuông góc AB, CH=HD.",
    ImagePath = "Hinh_tron/hinhtron_9.png",
    Code = @"\begin{tikzpicture}[scale=0.6]
\clip (-1.8,-2.5) rectangle (9,5);
\tkzDefPoints{2/4/A, 8/0/B, 2/0/H}
\tkzDefLine[orthogonal=through A](A,B)\tkzGetPoint{x}
\tkzInterLL(A,x)(B,H)\tkzGetPoint{C}
\tkzDefBarycentricPoint(H=2,C=-1)\tkzGetPoint{D}
\tkzDefMidPoint(A,B)\tkzGetPoint{I}
\coordinate (E) at ($(A)!(B)!(D)$);
\tkzMarkRightAngles(B,A,C A,H,B A,E,B)
\tkzDrawArc[color=black](I,A)(B)
\tkzLabelPoints[above](A)
\tkzLabelPoints[left](C)
\tkzLabelPoints[right](B)
\tkzLabelPoints[below](E)
\tkzLabelPoints[below left](H)
\tkzLabelPoints[above right](D,I)
\tkzMarkSegments[mark=||](C,H H,D)
\tkzDrawSegments(A,B B,C C,A A,E A,H)
\tkzDrawPoints[fill=white, size=9](A,B,C,D,H,E,I)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 10,
    Title = "Elip với hai tiêu điểm (tỷ lệ 0.9)",
    Category = "Hình tròn",
    Description = "Elip tâm O trên hệ trục Oxy, hai tiêu điểm F₁ và F₂, điểm M, đoạn MF₁ và MF₂ nét đứt, tỷ lệ 0.9.",
    ImagePath = "Hinh_tron/hinhtron_10.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.9,>=stealth,font=\footnotesize]
\draw[->] (-3,0)--(3.2,0) node[below]{$x$};
\draw[->] (0,-2)--(0,2.5) node[right]{$y$};
\draw (0,0) node[below left]{$O$};
\tkzDefPoints{0/0/O,-2.5/0/A_1,2.5/0/A_2,0/-1.5/B_1,0/1.5/B_2,-2/0/F_1,2/0/F_2}
\draw[color=blue,thick] (O) ellipse (2.5cm and 1.5cm);
\coordinate (M) at ($(O)+(60:2.5cm and 1.5cm)$);
\tkzDrawPoints[size=5,fill=black](A_1,A_2,B_1,B_2,F_1,F_2,M)
\tkzDrawSegments[dashed](M,F_1 M,F_2)
\tkzLabelPoints[below right,font=\footnotesize](B_1)
\tkzLabelPoints[above right,font=\footnotesize](B_2,A_2,M)
\tkzLabelPoints[below ,font=\footnotesize](F_1,F_2)
\tkzLabelPoints[above left,font=\footnotesize](A_1)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 11,
    Title = "Elip và hình chữ nhật ABCD",
    Category = "Hình tròn",
    Description = "Elip trên hệ trục Oxy, hình chữ nhật ABCD nội tiếp elip với A, B, C, D trên elip.",
    ImagePath = "Hinh_tron/hinhtron_11.png",
    Code = @"\begin{tikzpicture}[scale=0.6]
\def\xmin{-5} \def\xmax{5}
\def\ymin{-3} \def\ymax{3}
\coordinate [label=60:$A$] (A) at (4.472,0);
\coordinate [label=120:$B$] (B) at (0,2.237);
\tkzDefPoints{0/0/O, 2/0/Z, 0/-2.237/D, -4.472/0/C}
\tkzDrawCircle[radius](O,Z)
\tkzDrawPoints(A,B,C,D)
\tkzDrawSegments(A,B B,C C,D D,A)
\tkzLabelPoints(D,O)
\tkzLabelPoints[left](C)
\draw[->](\xmin,0)--(\xmax,0); \draw(\xmax-0.1,0) node[below]{$x$};
\draw[->](0,\ymin)--(0,\ymax); \draw(0,\ymax-0.2) node[right]{$y$};
\draw (0,0) ellipse [x radius=4.473cm, y radius =2.236cm];
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 12,
    Title = "Đường tròn với dây cung và trung điểm",
    Category = "Hình tròn",
    Description = "Đường tròn tâm I bán kính R, dây cung EF, H là trung điểm EF, IH vuông góc EF.",
    ImagePath = "Hinh_tron/hinhtron_12.png",
    Code = @"\begin{tikzpicture}[scale=0.5]
\clip (-4,-4) rectangle (5,5);
\tkzDefPoints{0/0/I, 4/0/A, -3/3/C, 3/3/D}
\tkzDrawCircle(I,A)
\tkzInterLC(C,D)(I,A)\tkzGetFirstPoint{E}\tkzGetSecondPoint{F}
\tkzDefMidPoint(E,F)\tkzGetPoint{H}
\tkzMarkRightAngle(I,H,F)
\tkzLabelSegment[pos=0.5,below right](I,F){$R$}
\tkzDrawSegments(E,F I,H I,F)
\tkzLabelPoints[below left](H)
\tkzLabelPoints[below](I)
\tkzLabelPoints[above right](F)
\tkzLabelPoints[above left](E)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 13,
    Title = "Đường tròn với hai đường thẳng vuông góc",
    Category = "Hình tròn",
    Description = "Đường tròn tâm I bán kính 3, hai đường thẳng Δ₁ và Δ₂, dây cung EF, IH vuông góc EF, góc FIE=90°, EH=3√2/2.",
    ImagePath = "Hinh_tron/hinhtron_13.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,scale=1] 
\tkzDefPoints{1/2/I,-3/1/A,2/6/D}
\draw (I) circle [radius=3];
\tkzInterLC[R](A,D)(I,3cm)
\tkzGetPoints{E}{F}
\tkzDrawLines[add=.4 and 0.1](E,F)
\tkzLabelLine[pos=-.2,above left](E,F){$\Delta_1$}
\tkzDrawLines[add=.3 and 0.1](I,A)
\tkzLabelLine[pos=-.3,above left](I,A){$\Delta_2$}
\coordinate (H) at ($(E)!(I)!(F)$);
\tkzDrawPoints[fill=white,size=4pt](I,E,F,H)
\tkzDrawSegments(I,H I,E I,F)
\tkzLabelSegment[pos=.5](E,H){$\frac{3\sqrt{2}}{2}$}
\tkzMarkRightAngles[size=0.2](I,H,E)
\tkzMarkRightAngles[size=0.2](F,I,E)
\tkzLabelPoints[above](F,H)
\tkzLabelPoints[above left](E)
\tkzLabelPoints[below](I)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 14,
    Title = "Đường tròn trên hệ trục tọa độ với tam giác vuông",
    Category = "Hình tròn",
    Description = "Đường tròn tâm I(1;0) bán kính √10 trên hệ trục Oxy, tam giác AMN vuông tại A, dây cung MN, góc NAM=90°, IH vuông góc MN.",
    ImagePath = "Hinh_tron/hinhtron_14.png",
    Code = @"\begin{tikzpicture}[line width=1.0pt,line join=round,>=stealth,scale=1]
\draw[->] (-3,0) -- (5,0) node[below] {\footnotesize $x$};
\foreach \x in {1}
\draw[shift={(\x,0)},color=black] (0pt,2pt) -- (0pt,-2pt) node[below right] {\footnotesize $\x$};
\draw[->] (0,-4) -- (0,4) node[left] {\footnotesize $y$};
\foreach \y in {-1,2,3}
\draw[shift={(0,\y)},color=black] (2pt,0pt) -- (-2pt,0pt) node[above left] {\footnotesize $\y$}; 
\draw[color=black] (3pt,2pt) node[below left] {\footnotesize $O$}; 
\tkzDefPoints{1/0/I,1/2/A,-2/-1/C,2/-1/D}
\draw (I) circle [radius=3.16];
\tkzInterLC[R](C,D)(I,3.16cm)
\tkzGetPoints{M}{N}
\coordinate (H) at ($(M)!(I)!(N)$);
\tkzDrawLines[add=.2 and 0.1](M,N)
\tkzDrawPoints[fill=white,size=2pt](I,A,M,N)
\tkzDrawSegments(A,M A,N I,N I,M)
\tkzDrawLines[dashed,add=1 and 1.3](A,I)
\draw[dashed] (A)--(0,2);
\draw[line width=.7pt] (-2,3)--(3.5,3);
\tkzMarkRightAngles[size=0.2](N,A,M)
\tkzMarkRightAngles[size=0.2](I,H,M)
\tkzLabelPoints[above right](I,A,M)
\tkzLabelPoints[above left](N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 15,
    Title = "Đường tròn với dây cung và khoảng cách",
    Category = "Hình tròn",
    Description = "Đường tròn tâm I bán kính 5, dây cung EF cắt đường thẳng Δ, H là trung điểm EF, IH vuông góc EF, IE=5, HE=2√5.",
    ImagePath = "Hinh_tron/hinhtron_15.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,scale=0.5] 
\tkzDefPoints{3/2/I,-6/0/A,-2/2/D}
\draw (I) circle [radius=5];
\tkzInterLC[R](A,D)(I,5cm)
\tkzGetPoints{E}{F}
\tkzDrawLines[add=.6 and 0.1](E,F)
\tkzLabelLine[pos=-.7,above](E,F){$\Delta$}
\coordinate (H) at ($(E)!(I)!(F)$);
\tkzDrawPoints[fill=white,size=4pt](I,E,F,H,A)
\tkzDrawSegments(I,H I,E)
\tkzLabelSegment[pos=.5,below](I,E){$5$}
\tkzLabelSegment[pos=.5,above](H,E){$2\sqrt{5}$}
\tkzMarkRightAngles[size=0.2](I,H,E)
\tkzLabelPoints[above](F,H)
\tkzLabelPoints[above left](E,A)
\tkzLabelPoints[below](I)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 16,
    Title = "Đường tròn với tiếp tuyến Δ",
    Category = "Hình tròn",
    Description = "Đường tròn tâm I bán kính R, tiếp tuyến Δ, IH vuông góc Δ tại H, IH=R.",
    ImagePath = "Hinh_tron/hinhtron_16.png",
    Code = @"\begin{tikzpicture}[scale=0.8,line cap=round,line join=round] 
\tikzset{label style/.style={font=\scriptsize}}
\tkzDefPoints{0/0/I,0/-2.5/C,1/-2.5/D}
\draw (I) circle [radius=2];
\tkzDrawLines[add=2.3 and 2.1](C,D)
\tkzLabelLine[pos=2.2,above](C,D){$\Delta$}
\coordinate (H) at ($(C)!(I)!(D)$);
\tkzDrawPoints[fill=black,size=3pt](I,H)
\tkzDrawSegments(I,H)
\tkzLabelSegment[pos=.5,left](I,H){$R$}
\tkzMarkRightAngles[size=0.2](I,H,D)
\tkzLabelPoints[above](I)
\tkzLabelPoints[below](H)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 17,
    Title = "Đường tròn với ba đường thẳng",
    Category = "Hình tròn",
    Description = "Đường tròn tâm K với ba đường thẳng d, d₁, d₂, hai góc vuông tại giao điểm với đường tròn.",
    ImagePath = "Hinh_tron/hinhtron_17.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,>=stealth,x=1.0cm,y=1.0cm,scale=.85]
\clip(1.32,-1.26) rectangle (6.54,3.66);
\draw[fill opacity=0.1] (3.75,3.03) -- (3.78,2.82) -- (3.99,2.85) -- (3.96,3.06) -- cycle; 
\draw[fill opacity=0.1] (2.7,0.05) -- (2.59,0.23) -- (2.41,0.12) -- (2.52,-0.06) -- cycle; 
\draw (4.24,1.04) circle (2.0393136100168605cm);
\draw (4.24,1.04)-- (3.96,3.06);
\draw [domain=1.32:6.54] plot(\x,{(-5.0724-0.28*\x)/-2.02});
\draw (4.24,1.04)-- (2.5,-0.06);
\draw [domain=1.32:6.54] plot(\x,{(--4.26-1.72*\x)/1.1});
\draw [,domain=1.32:6.54] plot(\x,{(-13.2--3.7*\x)/2.38});
\draw (4.28,1.04) node[anchor=north west] {$K$};
\draw (5.,2.16) node[anchor=north west] {$d$};
\draw (1.62,2.06) node[anchor=north west] {$d_1$};
\draw (2.06,3.6) node[anchor=north west] {$d_2$};
\draw [fill=black] (4.24,1.04) circle (1.0pt);
\draw [fill=black] (3.96,3.06) circle (1.0pt);
\draw [fill=black] (2.52,-0.06) circle (1.0pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 18,
    Title = "Đường tròn với tiếp tuyến vuông góc",
    Category = "Hình tròn",
    Description = "Đường tròn tâm I bán kính IM₀, tiếp tuyến Δ vuông góc với IM₀ tại M₀, vector IM₀.",
    ImagePath = "Hinh_tron/hinhtron_18.png",
    Code = @"\begin{tikzpicture}[scale=0.7, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/I,-2/1/M_0}
\clip (-3.5,-2.3) rectangle (2.5,2.6);
\draw[->] (I)--(M_0);
\tkzDrawCircle[radius](I,M_0)
\tkzDefPointBy[rotation=center M_0 angle 90](I)\tkzGetPoint{M'}
\tkzDefPointBy[rotation=center M_0 angle -90](I)\tkzGetPoint{M''} 
\draw (M')--(M'');
\node at (-3.2,-1) [above]{$\Delta$};
\tkzDrawPoints[fill=black,size=4](I,M_0)
\tkzLabelPoints[above left](M_0)
\tkzLabelPoints[below](I)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 19,
    Title = "Đường tròn với dây cung AB và Δ",
    Category = "Hình tròn",
    Description = "Đường tròn tâm I bán kính R, dây cung AB cắt đường thẳng Δ, H là trung điểm AB, IH vuông góc AB, IA=R.",
    ImagePath = "Hinh_tron/hinhtron_19.png",
    Code = @"\begin{tikzpicture}[scale=0.8,line cap=round,line join=round] 
\tikzset{label style/.style={font=\scriptsize}}
\tkzDefPoints{0/0/I,0/-1/C,1/-1/D}
\draw (I) circle [radius=2];
\tkzInterLC[R](C,D)(I,2cm)
\tkzGetPoints{A}{B}
\tkzDrawLines[add=.3 and 0.1](A,B)
\tkzLabelLine[pos=-.2,above](A,B){$\Delta$}
\coordinate (H) at ($(A)!(I)!(B)$);
\tkzDrawPoints[fill=black,size=4pt](I,A,B,H)
\tkzDrawSegments(I,H I,A)
\tkzLabelSegment[pos=.5,above](I,A){$R$}
\tkzMarkRightAngles[size=0.2](I,H,A)
\tkzLabelPoints[above](I)
\tkzLabelPoints[below left](B)
\tkzLabelPoints[below right](A)
\tkzLabelPoints[below](H)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 20,
    Title = "Đường tròn với tiếp tuyến Δ (lặp lại)",
    Category = "Hình tròn",
    Description = "Đường tròn tâm I bán kính R, tiếp tuyến Δ, IH vuông góc Δ tại H, IH=R.",
    ImagePath = "Hinh_tron/hinhtron_20.png",
    Code = @"\begin{tikzpicture}[scale=0.8,line cap=round,line join=round]
\tikzset{label style/.style={font=\scriptsize}} 
\tkzDefPoints{0/0/I,0/-2/C,1/-2/D}
\draw (I) circle [radius=2];
\tkzDrawLines[add=2.3 and 2.1](C,D)
\tkzLabelLine[pos=2.2,above](C,D){$\Delta$}
\coordinate (H) at ($(C)!(I)!(D)$);
\tkzDrawPoints[fill=black,size=3pt](I,H)
\tkzDrawSegments(I,H)
\tkzLabelSegment[pos=.5,left](I,H){$R$}
\tkzMarkRightAngles[size=0.2](I,H,D)
\tkzLabelPoints[above](I)
\tkzLabelPoints[below](H)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 21,
    Title = "Đường tròn với đường trung trực",
    Category = "Hình tròn",
    Description = "Đường tròn tâm I qua A và B, đường trung trực Δ của AB cắt AB tại M, IH vuông góc đường thẳng d.",
    ImagePath = "Hinh_tron/hinhtron_21.png",
    Code = @"\begin{tikzpicture}[scale=0.4]
\tkzDefPoints{-1/1/A,3/3/B,3/-2/I,4/5/E,-4/-1/F}
\tkzDefLine[mediator](A,B) \tkzGetPoints{C}{D}
\tkzInterLL(A,B)(C,D)\tkzGetPoint{M}
\tkzDrawCircle(I,A)
\tkzDefPointBy[projection=onto E--F](I)\tkzGetPoint{H}\tkzMarkRightAngle[size=0.3](I,H,E)
\tkzDrawPoints[fill=black](A,B,I,M)
\tkzDrawSegments(E,F I,C A,B I,H)
\tkzLabelPoints[below](A,B,I)\tkzLabelPoints[right](M)
\node at (E) [below] {$d$};
\node at (C) [left] {$\Delta$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 22,
    Title = "Đường tròn với hai đường thẳng d₁ và d₂",
    Category = "Hình tròn",
    Description = "Đường tròn tâm I, đường thẳng d₁ đi qua tâm I, đường thẳng d₂ cắt đường tròn tại A và B, góc vuông tại B.",
    ImagePath = "Hinh_tron/hinhtron_22.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,>=stealth,x=1.0cm,y=1.0cm,scale=.85]
\clip(1.56,-0.84) rectangle (7.94,4.84);
\draw[fill opacity=0.1] (6.7,1.23) -- (6.5,1.3) -- (6.42,1.1) -- (6.62,1.03) -- cycle; 
\draw (4.3,1.84) circle (2.46cm);
\draw (4.3,-0.84) -- (4.3,4.84);
\draw (5.36,4.72) node[anchor=north west] {$A$};
\draw (6.82,1.38) node[anchor=north west] {$B$};
\draw (4.44,0.48) node[anchor=north west] {$d_1$};
\draw (3.82,2.36) node[anchor=north west] {$I$};
\draw (4.3,1.84)-- (6.62,1.03);
\draw [domain=1.5:7.5] plot(\x,{(-14.55--2.32*\x)/0.811});
\draw (6.8,3.78) node[anchor=north west] {$d_2$};
\draw [fill=black] (4.3,1.84) circle (1.0pt);
\draw [fill=black] (5.36,4.06) circle (1.0pt);
\draw [fill=black] (6.62,1.03) circle (1.0pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 23,
    Title = "Đường tròn với dây cung và trung điểm M",
    Category = "Hình tròn",
    Description = "Đường tròn tâm I, dây cung AB cắt đường thẳng d, M là trung điểm AB, góc vuông AMB.",
    ImagePath = "Hinh_tron/hinhtron_23.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,>=stealth,x=1.0cm,y=1.0cm]
\clip(1.24,-1.) rectangle (7.7,4.92);
\draw (5.93,2.85) -- (5.74,2.76) -- (5.83,2.57) -- (6.03,2.66) -- cycle; 
\draw (4.3,1.84) circle (2.46cm);
\draw (5.36,4.06)-- (6.7,1.27);
\draw [domain=1.24:7.7] plot(\x,{(-0.36--0.82*\x)/1.73});
\draw (4.3,-1.) -- (4.3,4.92);
\draw (5.6,4.4) node[left] {$A$};
\draw (6.8,1.4) node[anchor=north west] {$B$};
\draw (5.6,2.5) node[anchor=north west] {$M$};
\draw (4.44,0.48) node[anchor=north west] {$d$};
\draw (4.46,1.9) node[anchor=north west] {$I$};
\draw [fill=black] (4.3,1.84) circle (1.0pt);
\draw [fill=black] (5.36,4.06) circle (1.0pt);
\draw [fill=black] (6.7,1.27) circle (1.0pt);
\draw [fill=black] (6.03,2.67) circle (1.0pt);
\end{tikzpicture}"
},

// ❌ TikZ lỗi (Id=24): Command '['pdflatex', '-interaction=nonstopmode', 'E:/cai_dat/NBH Tool/NBH Tool/bin/X64/Release/Images\\Hinh_tron\\hinhtron_24.tex']' returned non-zero exit status 1.

new TikzItem2
{
    Id = 25,
    Title = "Đường tròn với tiếp tuyến Δ (lặp lại)",
    Category = "Hình tròn",
    Description = "Đường tròn tâm I bán kính IM₀, tiếp tuyến Δ vuông góc với IM₀ tại M₀, vector IM₀.",
    ImagePath = "Hinh_tron/hinhtron_25.png",
    Code = @"\begin{tikzpicture}[scale=0.7, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/I,-2/1/M_0}
\clip (-3.5,-2.3) rectangle (2.5,2.6);
\draw[->] (I)--(M_0);
\tkzDrawCircle[radius](I,M_0)
\tkzDefPointBy[rotation=center M_0 angle 90](I)\tkzGetPoint{M'}
\tkzDefPointBy[rotation=center M_0 angle -90](I)\tkzGetPoint{M''} 
\draw (M')--(M'');
\node at (-3.2,-1) [above]{$\Delta$};
\tkzDrawPoints[fill=black,size=4](I,M_0)
\tkzLabelPoints[above left](M_0)
\tkzLabelPoints[below](I)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 26,
    Title = "Đường tròn tâm I bán kính R",
    Category = "Hình tròn",
    Description = "Đường tròn tâm I bán kính R, đoạn IM=R.",
    ImagePath = "Hinh_tron/hinhtron_26.png",
    Code = @"\begin{tikzpicture}[scale=1]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/I,1/0/M}
\tkzDrawCircle[radius](I,M)
\tkzLabelPoints[below](I)
\tkzLabelPoints[right](M)
\tkzDrawPoints[size=5,fill=black](I,M)
\tkzDrawSegments(I,M)
\tkzLabelSegment[pos=0.5,below](I,M){\scriptsize $R$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 27,
    Title = "Đường tròn với bán kính và tiếp tuyến",
    Category = "Hình tròn",
    Description = "Đường tròn tâm I bán kính R, bán kính IA=R, tiếp tuyến Δ vuông góc IA tại A.",
    ImagePath = "Hinh_tron/hinhtron_27.png",
    Code = @"\begin{tikzpicture}[scale=0.9]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/I,0/-1/A,-2/-1/H,2/-1/K}
\tkzDrawCircle[radius](I,A)
\tkzLabelPoints[below](A)
\tkzLabelPoints[above](I)
\tkzDrawPoints[size=5,fill=black](I,A)
\tkzDrawSegments(I,A H,K)
\tkzLabelSegment[pos=0.5,right](I,A){\scriptsize$R$}
\tkzLabelSegment[pos=1,below](H,K){\scriptsize$\Delta$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 28,
    Title = "Đường tròn với hai tiếp tuyến Δ₁ và Δ₂",
    Category = "Hình tròn",
    Description = "Đường tròn tâm I bán kính 2, hai tiếp tuyến Δ₁ và Δ₂ tại M và N, các bán kính IA, IM, IN.",
    ImagePath = "Hinh_tron/hinhtron_28.png",
    Code = @"\begin{tikzpicture}[scale=0.8,font=\footnotesize]
\def\r{2}
\path
(110:\r) coordinate (A)
(0:0) coordinate (I) --(25:\r) coordinate (M)--([turn]-90:2cm) coordinate (Mt)node[right]{$\Delta_1$}
(0:0) coordinate (I) --(-90:\r) coordinate (N)--([turn]90:2cm) coordinate (Nt)node[right]{$\Delta_2$};
\draw 
(I) circle (\r)
(I)--(A)
(I)--(M)
(I)--(N)
(Mt)--($(Mt)!2!(M)$)
(Nt)--($(Nt)!2!(N)$);
\foreach \x/\g in {I/180,M/60,N/-90,A/110} \draw[fill=black] (\x) circle (.04)+(\g:.3) node{$\x$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 29,
    Title = "Đường tròn tâm I bán kính R (tỷ lệ 0.8)",
    Category = "Hình tròn",
    Description = "Đường tròn tâm I bán kính R, đoạn IM=R, tỷ lệ 0.8.",
    ImagePath = "Hinh_tron/hinhtron_29.png",
    Code = @"\begin{tikzpicture}[scale=0.8]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/I,2/0/M}
\tkzDrawCircle[radius](I,M)
\tkzLabelPoints[below](I)
\tkzLabelPoints[right](M)
\tkzDrawPoints[size=5,fill=black](I,M)
\tkzDrawSegments(I,M)
\tkzLabelSegment[pos=0.5,below](I,M){$R$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 30,
    Title = "Đường tròn ngoại tiếp tam giác với đường cao",
    Category = "Hình tròn",
    Description = "Đường tròn tâm O ngoại tiếp tam giác ABC, trực tâm H, đường cao BD và CE, A' đối xứng A qua O, M là trung điểm BC, vector AH và OM.",
    ImagePath = "Hinh_tron/hinhtron_30.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[xmin=-0.55, xmax=5.55, ymin=-1.7, ymax=5]
\tkzClip
\tkzDefPoints{0/0/B,5/0/C,1.5/4.5/A}
\tkzCircumCenter(A,B,C)\tkzGetPoint{O}
\tkzDrawCircle(O,A)
\tkzDefMidPoint(B,C)\tkzGetPoint{M}
\tkzDefPointBy[projection=onto A--B](C)\tkzGetPoint{E}
\tkzDefPointBy[projection=onto A--C](B)\tkzGetPoint{D}
\tkzInterLL(B,D)(C,E)\tkzGetPoint{H}
\tkzDefPointBy[symmetry=center O](A)\tkzGetPoint{A'}
\tkzDrawPoints[fill=black](A,B,C,D,E,H,O,M,A')
\tkzDrawSegments(A,B B,C C,A B,D C,E A,A' B,A' C,A' H,A')
\draw[->] (A)--(H) (O)--(M);
\tkzLabelPoints[above](A)
\tkzLabelPoints[below left](B,M)
\tkzLabelPoints[below](H,A')
\tkzLabelPoints[right](O,D)
\tkzLabelPoints[left](E)
\tkzLabelPoints[below right](C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 31,
    Title = "Đường tròn ngoại tiếp tam giác vuông với đối xứng",
    Category = "Hình tròn",
    Description = "Đường tròn tâm O ngoại tiếp tam giác ABC, trực tâm H, B' đối xứng B qua O, đường cao AM và CN, góc vuông tại M, N, C, A.",
    ImagePath = "Hinh_tron/hinhtron_31.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tikzset{label style/.style={font=\footnotesize}}
\coordinate (B) at (0,0);
\coordinate (A) at (1,3);
\coordinate (C) at (4,0);
\coordinate (M) at ($(B)!(A)!(C)$);
\coordinate (N) at ($(A)!(C)!(B)$);
\tkzInterLL(A,M)(C,N) \tkzGetPoint{H}
\tkzDefCircle[circum](A,B,C) \tkzGetPoint{O}

\coordinate (B') at ($(B)!2!(O)$);
\tkzCalcLength[cm](O,A) \tkzGetLength{r}
\draw[name path=(C)] (O) circle (\r cm);
\tkzDrawSegments(A,B B,C A,C A,M B,H C,N B',C B,B' A,B')
\tkzDrawPoints[fill=black](M,A,B,C,H,N,O,B')
\tkzLabelPoints[above](A,O)
\tkzLabelPoints[below](B,C,M)
\tkzLabelPoints[left](N)
\tkzLabelPoints[right](B')
\tkzLabelPoints[above right](H)
\tkzMarkRightAngles[size=0.2](A,M,B A,N,C B,C,B' B,A,B')
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 32,
    Title = "Đường tròn nội tiếp hình vuông",
    Category = "Hình tròn",
    Description = "Đường tròn tâm O bán kính 1cm nội tiếp hình vuông A₀A₁A₂A₃, các đường chéo A₀A₂ và A₁A₃.",
    ImagePath = "Hinh_tron/hinhtron_32.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=1.6]
\draw (0,0) node[below left] {$O$} circle (1cm);
\coordinate (A) at (1,0);
\coordinate (O) at (0,0);
\tkzDefPointBy[rotation= center O angle 90](A)
\tkzGetPoint{B}
\tkzDefPointBy[rotation= center O angle 180](A)
\tkzGetPoint{C}
\tkzDefPointBy[rotation= center O angle -90](A)
\tkzGetPoint{D}
\draw (A)--(C) (B)--(D);
\draw [line width = 1pt] (A)--(B)--(C)--(D)--(A);
\tkzDrawPoints(A,B,C,D)
\draw (A) node[right] {$A_0$};
\draw (B) node[above] {$A_1$};
\draw (C) node[left] {$A_2$};
\draw (D) node[below] {$A_3$};
\end{tikzpicture}"
},

