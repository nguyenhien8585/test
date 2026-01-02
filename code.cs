
new TikzItem2
{
    Id = 1,
    Title = "Hai đường thẳng song song và mặt phẳng",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành ABCD với hai đường thẳng song song a và b cắt mặt phẳng α tạo góc α.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_1.png",
    Code = @"\begin{tikzpicture}[font=\footnotesize, line join=round, line cap=round,>=stealth,scale=0.6]
\tkzDefPoints{0/0/A, 5/0/B, 6/3/C, 2/1.5/I, 4/1.5/J, 2/4.5/K}
\tkzDefPointBy[translation = from B to C](A)
\tkzGetPoint{D}
\tkzDefPointBy[symmetry = center I](K)
\tkzGetPoint{P}
\tkzDefPointBy[translation = from I to J](K)
\tkzGetPoint{K'}
\tkzDefPointBy[translation = from I to J](P)
\tkzGetPoint{P'}
\tkzInterLL(A,B)(K,P)
\tkzGetPoint{Q}
\tkzInterLL(A,B)(K',P')
\tkzGetPoint{Q'}
\tkzDrawSegments[dashed](I,Q J,Q')
\tkzDrawSegments(A,B B,C C,D D,A K,I Q,P K',J Q',P')
\tkzMarkAngle[size=.8](B,A,D)
\draw (A) node [above right] {$\alpha$};
\draw ($(K)$) node [below left] {$a$};
\draw ($(K')$) node [below left] {$b$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 2,
    Title = "Khoảng cách bằng nhau từ hai điểm đến mặt phẳng",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Minh họa d(A,α)=d(B,α), hai điểm A và B có khoảng cách bằng nhau đến mặt phẳng α, với hình chiếu A' và B'.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_2.png",
    Code = @"\begin{tikzpicture}[line width=0.6,>=stealth, scale=1.35]
\coordinate (a) at (0,0);
\coordinate (b) at (1,1);
\coordinate (c) at (4.3,1);
\coordinate (d) at ($(a)+(c)-(b)$);
\coordinate (M) at (0.8,1.6);
\coordinate (N) at (4,1.6);
\coordinate (A) at ($(M)!0.2!(N)$);
\coordinate (A') at ($(A)-(0,1)$);
\coordinate (B) at ($(M)!0.5!(N)$);
\coordinate (B') at ($(B)-(0,1)$);
\node at (2,-0.6) {$\mathrm{d}\big(A,(\alpha)\big)=\mathrm{d}\big(B,(\alpha)\big)$};
\clip (-0.3,-0.2) rectangle (4.4,2.13);
\draw (a)--(b)--(c)--(d)--(a) (M)--(N) (A)--(A') (B)--(B');
\draw[fill=black] (A) circle(0.8pt) node[above]{$A$};
\draw[fill=black] (A') circle(0.4pt) node[below]{$A'$};
\draw[fill=black] (B) circle(0.8pt) node[above]{$B$};
\draw[fill=black] (B') circle(0.4pt) node[below]{$B'$};
\node at (0.31, 0.13) {$\alpha$};
\draw (0.33,0.33)..controls(0.5,0.3)and(0.5,0.1)..(0.4,0);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 3,
    Title = "Tỷ lệ khoảng cách từ hai điểm đến mặt phẳng",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Minh họa công thức d(A,α)/d(B,α)=AI/BI, tỷ lệ khoảng cách từ A, B đến mặt phẳng α bằng tỷ lệ phân đoạn trên đường thẳng.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_3.png",
    Code = @"\begin{tikzpicture}[line width=0.6,>=stealth, scale=1.35]
\coordinate (A) at (0,0);
\coordinate (B) at (1,1);
\coordinate (C) at (4.3,1);
\coordinate (D) at ($(A)+(C)-(B)$);
\coordinate (M) at (0.8,2);
\coordinate (H) at (0.8,0.5);
\coordinate (I) at (3,0.5);
\coordinate (E) at ($(M)!0.2!(I)$);
\coordinate (E') at ($(H)!0.2!(I)$);
\coordinate (G) at ($(M)!0.5!(I)$);
\coordinate (G') at ($(H)!0.5!(I)$);
\coordinate (F) at ($(M)!1.2!(I)$);
\coordinate (N) at ($(M)!1.223!(I)$);
\coordinate (P) at ($(M)!1.3!(I)$);
\coordinate (a) at (1.2,1);
\coordinate (b) at (2.28,1);
\node at (2,-0.6) {$\dfrac{\mathrm{d}\big(A,(\alpha)\big)}{\mathrm{d}\big(B,(\alpha)\big)}=\dfrac{AI}{BI}$};
\clip (-0.1,-0.2) rectangle (4.4,2.13);
\draw (a)--(B)--(A)--(D)--(C)--(b) (M)--(I) (H)--(I) (E)--(E') (N)--(P) (G)--(G');
\draw[dashed] (I)--(F) (a)--(b);
\draw[fill=black] (E) circle(0.8pt);
\node at ($(E)+(0.1,0.25)$) {$A$};
\draw[fill=black] (E') circle(0.4pt);
\node at ($(E')+(0,-0.2)$) {$A'$};
\draw[fill=black] (G) circle(0.8pt);
\node at ($(G)+(0.1,0.25)$) {$B$};
\draw[fill=black] (G') circle(0.4pt);
\node at ($(G')+(0,-0.2)$) {$B'$};
\draw[fill=black] (I) circle(0.8pt);
\node at ($(I)+(0.2,0.1)$) {$I$};
\node at (0.31, 0.13) {$\alpha$};
\draw (0.33,0.33)..controls(0.5,0.3)and(0.5,0.1)..(0.4,0);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 4,
    Title = "Góc giữa đường thẳng và mặt phẳng",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Góc α giữa mặt phẳng và đường thẳng a, điểm A trên a, B là hình chiếu vuông góc của A xuống đường thẳng b nằm trong mặt phẳng.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_4.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/M,5/0/N,1.5/2.5/Q,6.5/2.5/P,2.5/-0.5/R,2.5/3.5/S,2.5/1.7/B,1.8/0.4/E,6/2.2/F}
\tkzDefPointBy[homothety = center F ratio 0.4](E) \tkzGetPoint{A}
\tkzInterLL(M,N)(R,S) \tkzGetPoint{I}
\tkzDrawSegments(M,N N,P P,Q Q,M R,I B,S E,F A,B)
\tkzDrawSegments[dashed](I,B)
\tkzMarkAngles[size=1](N,M,Q)
\tkzLabelAngles[color=black,pos=.6](Q,M,N){$\alpha$}
\tkzLabelSegment[pos=0.9,right](R,S){$b$}
\tkzLabelSegment[pos=0.9](E,F){$a$}
\tkzMarkRightAngles[size=.3](B,A,F S,B,A)
\tkzDrawPoints[fill=black](A,B)
\tkzLabelPoints(A)
\tkzLabelPoints[left](B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 5,
    Title = "Góc giữa đường thẳng song song và mặt phẳng",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Đường thẳng a song song với b, M và M' trên a, A và B là hình chiếu vuông góc, góc α giữa a và mặt phẳng.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_5.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/O,5/0/N,1.5/2.5/Q,6.5/2.5/P,1.6/3.5/R,5.5/3.5/S,1.6/1.8/E,4.7/3.5/M,4.7/1.8/M',2/2.3/G,4.8/0.2/H}
\tkzDefPointBy[translation = from R to S](E) \tkzGetPoint{F}
\tkzInterLL(G,H)(E,F) \tkzGetPoint{A}
\tkzDefPointBy[translation = from M' to M](A) \tkzGetPoint{B}
\tkzInterLL(P,Q)(A,B) \tkzGetPoint{J}
\tkzInterLL(P,Q)(M,M') \tkzGetPoint{K}
\tkzDrawSegments(O,N N,P P,K J,Q Q,O A,B M,M' R,S E,F G,H)
\tkzDrawSegments[dashed](J,K)
\tkzMarkAngles[size=1](N,O,Q)
\tkzLabelAngles[color=black,pos=.6](Q,O,N){\normalsize $\alpha$}
\tkzLabelSegment[pos=0.1,above](R,S){\normalsize $b$}
\tkzLabelSegment[pos=0.9,above](G,H){\normalsize $a$}
\tkzMarkRightAngles[size=.3](B,A,H A,B,M)
\tkzDrawPoints[fill=black](A,B,M,M')
\tkzLabelPoints[above](B,M)
\tkzLabelPoints[below](A,M')
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 6,
    Title = "Hai đường thẳng vuông góc trong không gian",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Đường thẳng a và b vuông góc nhau tại điểm M, đường thẳng MN vuông góc với cả a và b.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_6.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/-1/A,0/1.5/B, 0/-2/C, 3/0/D,0/0/M, 1.5/-1/N}
\tkzDrawSegments(A,B C,D M,N)
\tkzMarkRightAngles(B,M,N M,N,D)
\tkzLabelSegment[pos=0.8,above left](A,B){$a$}
\tkzLabelSegment[pos=0.7,above](C,D){$b$}
\tkzLabelPoints[below right](N)
\tkzLabelPoints[above left](M)
\tkzDrawPoints[fill=black](M,N)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 7,
    Title = "Hình chóp S.ABC với góc giữa mặt bên và đáy",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình chóp tam giác S.ABC với góc α giữa mặt bên SBC và mặt đáy (góc β), M là chân đường cao từ S, K và H là các điểm chiếu.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_7.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/A,5/0/B, 6/2/C,1/2/D,2/2/E,2/1/M,2/4/S}
\coordinate (K) at ($(C)!0.65!(B)$);
\coordinate (H) at ($(S)!0.4!(K)$);
\tkzDrawPolygon(S,B,C)
\tkzDrawSegments(A,B A,D D,E S,M S,K M,B)
\tkzDrawSegments[dashed](E,C M,K M,H M,C)
\tkzMarkAngles[size=0.7cm,arc=l](B,A,D)
\tkzLabelAngles[pos=0.4,rotate=30](B,A,D){\footnotesize $\beta$}
\tkzMarkAngles[size=0.9cm,arc=l](B,S,C)
\tkzLabelAngles[pos=0.6,rotate=30](B,S,C){\footnotesize $\alpha$}
\tkzMarkRightAngle[size=0.2](M,K,B)
\tkzMarkRightAngle[size=0.2](M,H,K)
\tkzDrawPoints[size=5,fill=black](S,M,K,H)
\tkzLabelPoints[below,font=\footnotesize](M)
\tkzLabelPoints[left,font=\footnotesize](S)
\tkzLabelPoints[below right,font=\footnotesize](K)
\tkzLabelPoints[right,font=\footnotesize](H)
\tkzLabelSegment[pos=0.7,right](B,C){$c$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 8,
    Title = "Hình chóp với đường cao và góc mặt bên",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình chóp S.ABC với đỉnh S, M là chân đường cao, H là hình chiếu lên cạnh BC, góc α và β giữa các mặt phẳng.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_8.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/A,4/0/B, 6/2/C,2/2/D,3/1/M}
\coordinate (H) at ($(C)!0.65!(B)$);
\coordinate (S) at ($(H)+(0,3)$);
\tkzInterLL(M,S)(C,D)\tkzGetPoint{F}
\tkzInterLL(M,H)(S,B)\tkzGetPoint{T}
\tkzDrawPolygon(S,B,C)
\tkzDrawSegments(A,B A,D M,B D,F S,M)
\tkzDrawSegments[dashed](F,C F,C M,H M,C)
\tkzMarkAngles[size=0.7cm,arc=l](B,A,D)
\tkzLabelAngles[pos=0.4,rotate=30](B,A,D){\footnotesize $\beta$}
\tkzMarkAngles[size=0.6cm,arc=l](B,S,C)
\tkzLabelAngles[pos=0.4,rotate=30](B,S,C){\footnotesize $\alpha$}
\tkzMarkRightAngle[size=0.2](M,H,B)
\tkzDrawPoints[size=5,fill=black](S,M,H)
\tkzLabelPoints[left,font=\footnotesize](M)
\tkzLabelPoints[above,font=\footnotesize](S)
\tkzLabelPoints[below right,font=\footnotesize](H)
\tkzLabelSegment[pos=0.7,right](B,C){$c$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 9,
    Title = "Hai mặt phẳng với đường thẳng d và điểm M",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hai mặt phẳng tạo góc α và β, đường thẳng d nằm trong một mặt phẳng, điểm M với hình chiếu H lên d.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_9.png",
    Code = @"\begin{tikzpicture}[line width=0.6pt,scale=1.2]
\coordinate (A) at (0,0);
\coordinate (B) at (1,1);
\coordinate (C) at (4.3,1);
\coordinate (D) at ($(A)+(C)-(B)$);
\coordinate (A1) at ($(A)+(1.2,0)$);
\coordinate (g) at (1.2,1);
\coordinate (B1) at ($(B)+(1.8,0)$);
\coordinate (C1) at ($(B)+(1.8,1.4)$);
\coordinate (D1) at ($(A1)+(C1)-(B1)$);
\coordinate (M) at (3.2,0.5);
\coordinate (H) at ($(A1)!0.5!(B1)$);
\clip (-0.1,-0.2) rectangle (4.4,2.4);
\draw (g)--(B)--(A)--(A1)--(B1)--(C1)--(D1)--(A1)--(D)--(C)--(B1) (M)--(H);
\draw[dashed] (g)--(B1);
\node at (0.32, 0.12) {$\beta$};
\draw (0.33,0.33)..controls(0.5,0.3)and(0.5,0.1)..(0.4,0);
\draw (1.2,1.1)..controls(1.3,1.1)and(1.55,1.1)..(1.45,1.55);
\node at (1.35, 1.3) {$\alpha$};
\draw[fill=black] (M) circle(1pt);
\node at ($(M)+(0.3,0)$) {$M$};
\draw[fill=black] (H) circle(0.6pt);
\node at ($(H)+(-0.15,0.15)$) {$H$};
\node at ($(A1)+(0.2,0.35)$) {$d$};
\tkzMarkRightAngle[size=0.17](B1,H,M)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 10,
    Title = "Hình bình hành với khoảng cách từ điểm đến đường thẳng",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành ABCD với góc α, đường thẳng a, điểm O và H là hình chiếu vuông góc của O lên a.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_10.png",
    Code = @"\begin{tikzpicture}[scale=.7, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[xmin=-1,xmax=7,ymin=-1,ymax=3] 
\tkzClip
\tkzDefPoints{0/0/A, 5/0/B,2/2/D}
\tkzDefPointsBy[translation= from A to B](D){C}
\tkzDrawSegments(A,B B,C C,D D,A)
\tkzDefPoints{1.5/.3/E, 6/1.5/F, 2/1.5/O}
\tkzDrawSegments(E,F)
\tkzLabelSegment(E,F){$a$}
\coordinate (H) at ($(E)!0.3!(F)$);
\tkzLabelPoints[right,below](H)
\tkzLabelPoints[right](O)
\tkzDrawPoints[fill=black](O,H)
\tkzMarkRightAngles(O,H,F)
\tkzDrawSegments(O,H)
\tkzMarkAngles[size=0.7](B,A,D)
\tkzLabelAngle[pos=.4](D,A,B){$\alpha$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 11,
    Title = "Hình bình hành với đường vuông góc không gian",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành ABCD với góc α, điểm O, H và M tạo thành đường gấp khúc vuông góc MHO.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_11.png",
    Code = @"\begin{tikzpicture}[scale=.7, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/A, 5/0/B,2/2/D, 4.5/3/O, 4.5/1/H, 2.5/1/M,3.5/2/E, 4.5/2/F}
\tkzDefPointsBy[translation= from A to B](D){C}
\tkzDrawSegments(A,B B,C C,F E,D D,A O,H H,M M,O)
\tkzDrawSegments[dashed](E,F)
\tkzDrawPoints[fill=black](O,M,H)
\tkzLabelPoints[above](O)
\tkzLabelPoints[left]( M)
\tkzLabelPoints[right](H)
\tkzMarkRightAngles(O,H,M)
\tkzMarkAngles[size=0.7](B,A,D)
\tkzLabelAngle[pos=.4](D,A,B){$\alpha$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 12,
    Title = "Hình chiếu của hai điểm lên đường thẳng",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành với góc α, điểm M và H được chiếu lên đường thẳng a thành các điểm A và B.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_12.png",
    Code = @"\begin{tikzpicture}[scale=.6, font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzInit[xmin=-1,xmax=7,ymin=-1,ymax=5] 
\tkzClip
\tkzDefPoints{0/0/A', 5/0/B',2/2/D', 4.5/3/O, 4.5/1/H, 2.5/1/M,3.5/2/E, 4.5/2/F, 1.5/4/A1,5.5/4/B1}
\tkzDefPointsBy[translation= from A' to B'](D'){C'}
\tkzDrawSegments(A',B' B',C' C',D' D',A' A1,B1)
\tkzLabelSegment[above](A1,B1){$a$}
\tkzDefPointBy[projection= onto A1--B1](M) \tkzGetPoint{A}
\tkzLabelPoints[above](A)
\tkzDefPointBy[projection= onto A1--B1](H) \tkzGetPoint{B}
\tkzLabelPoints[above](B)
\tkzDrawSegments(A,M H,B)
\tkzDrawPoints[fill=black](A,B,M,H)
\tkzLabelPoints[below](H, M)
\tkzMarkAngles[size=0.9](B',A',D')
\tkzLabelAngle[pos=.5](D',A',B'){$\alpha$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 13,
    Title = "Lăng trụ với hai mặt phẳng song song",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Lăng trụ ABCD.A'B'C'D' với hai mặt đáy tạo góc α và β, điểm M với hình chiếu H xuống mặt đáy.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_13.png",
    Code = @"\begin{tikzpicture}[scale=1.5, font=\footnotesize, line join=round, line cap=round,>=stealth]
\coordinate(A) at (0,0); 
\coordinate(A') at (0,2);
\coordinate (B) at (2,0);
\coordinate(B') at (2,2);
\coordinate (C) at (3,0.5);
\coordinate(C') at (3,2.5);
\coordinate (D) at (1,0.5);
\coordinate(D') at (1,2.5);
\coordinate (M) at (1.3,2.2);
\coordinate (H) at (1.3,.2);
\coordinate (E) at (1.3,2.0);
\draw (A) -- (B) --(C) -- (D)--(A)(A') -- (B') -- (C')--(D')--(A');
\draw (E) -- (H);
\tkzDrawSegments[dashed](M,E)
\tkzLabelPoints[left](M,H)
\tkzDrawPoints[fill=black](M,H)
\tkzMarkAngles[size=0.7](B,A,D)
\tkzLabelAngle[pos=.4](D,A,B){$\beta$}
\tkzMarkAngles[size=0.7](B',A',D')
\tkzLabelAngle[pos=.4](D',A',B'){$\alpha$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 14,
    Title = "Hình chóp với hai đường thẳng trong không gian",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình chóp E.ABCD với F trên cạnh bên, hai đường thẳng a và b trong không gian tạo góc α và β, điểm H và M.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_14.png",
    Code = @"\begin{tikzpicture}[scale=.6][>=stealth, line join=round, line cap = round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/A, 4/0/B, 5/2/C, 1/2/D, 3/4/E, 4/6/F, 3.5/2/G, 2/1/H, 2/3.5/K,4/3/M, 7/3.75/N, 2/0.5/I}
\tkzDrawSegments(A,B B,C A,D D,G B,E E,F C,F H,K M,N)
\tkzDrawPoints[fill=black](H,M)
\tkzDrawSegments[dashed](G,C I,H)
\tkzMarkAngle[mkpos=.3,size=.8](B,A,D)
\tkzMarkAngle[mkpos=.2,size=.6](B,E,F)
\draw (1.95,3)node[left]{$a$} (6,2.4)node[above]{$b$} (0.4,-0.13)node[above]{\scriptsize$\alpha$} (2.9,4)node[right]{\scriptsize$\beta$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 15,
    Title = "Góc giữa hai đường thẳng chéo nhau",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình chóp E.ABCD với đường thẳng m và n chéo nhau, giao điểm I, góc α và β giữa các mặt phẳng.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_15.png",
    Code = @"\begin{tikzpicture}[scale=.7][>=stealth, line join=round, line cap = round]
\tkzDefPoints{0/0/A, 4/0/B, 5/2/C, 1/2/D, 3/4/E, 4/6/F, 3.5/2/G, 2/1/H, 3.73/1/K,4/3/M, 4.5/1/N}
\tkzDrawSegments(A,B B,C A,D D,G B,E E,F C,F H,K M,N)
\tkzDrawPoints[fill=black](N)
\tkzDrawSegments[dashed](G,C K,N)
\tkzMarkAngle[mkpos=.3,size=.8](B,A,D)
\tkzMarkAngle[mkpos=.2,size=.6](B,E,F)
\tkzMarkAngle[mkpos=.2,size=.6](M,N,K)
\draw (3,1)node[below]{$m$} (4,3)node[right]{$n$} (0.4,-0.12)node[above]{\scriptsize $\alpha$} (2.95,4)node[right]{\scriptsize$\beta$} (4.75,1)node[below]{$I$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 16,
    Title = "Hình chóp S.ABC với đường cao và hình chiếu",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình chóp S.ABC với đỉnh S, H là chân đường cao, I là hình chiếu vuông góc của S lên BC, góc α tại đáy.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_16.png",
    Code = @"\begin{tikzpicture}[scale=.7][>=stealth, line join=round, line cap = round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/A, 4/0/B, 5/2/C, 1/2/D, 2/1/H, 2/4/S, 2/2/E, 4.5/1/I, 3.5/1/L}
\tkzDrawSegments(A,B B,C A,D D,E S,H H,L S,B S,C S,I H,B)
\tkzDrawPoints(I,S,H)
\tkzDrawSegments[dashed](E,C L,I H,C)
\tkzMarkAngle[mkpos=.3,size=.8](B,A,D)
\tkzMarkAngle[mkpos=.2,size=.6](S,I,H)
\tkzMarkRightAngle(S,I,C)
\tkzMarkRightAngle(H,I,B)
\draw (2,1)node[below]{$H$} (4.5,1)node[right]{$I$} (0.4,-0.05)node[above]{$\alpha$} (2,4)node[above]{$S$} (4,0)node[below]{$B$} (5,2)node[right]{$C$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 17,
    Title = "Hình chóp với nhiều đường thẳng trong không gian",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình chóp phức tạp với các đường thẳng a, b, c, d trong không gian, góc α và β, điểm I là giao điểm.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_17.png",
    Code = @"\begin{tikzpicture}[scale=.7][>=stealth, line join=round, line cap = round]
\tkzDefPoints{0/0/A, 7/0/B, 8/2/C, 1/2/D, 2/0/H, 2/2/G, 4/2/M, 3/1/I, 2/4/N, 4/6/Q, 3/4/T, 3/0.5/P, 7/1.5/X, 5/1.5/R, 6/0.5/V}
\tkzDrawSegments(A,B B,C A,D D,G M,C H,M H,N M,Q I,T N,Q P,X R,V)
%\tkzDrawPoints(I)
\tkzDrawSegments[dashed](G,M)
\tkzMarkRightAngle(H,I,T)
\tkzMarkAngle[mkpos=.3,size=.8](B,A,D)
\tkzMarkAngle[mkpos=.3,size=.6](H,N,Q)
\draw (3,3)node[right]{$d$} (3.6,1.4)node[below]{$c$} (0.1,0.22)node[right]{$\alpha$} (1.9,3.85)node[right]{$\beta$} (4,0.1)node[above]{$a$} (6.2,0.3)node[above]{$b$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 18,
    Title = "Hai hình bình hành với đường thẳng qua tâm",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hai hình bình hành ABCD với góc α và β, đường thẳng m và n đi qua tâm I của mỗi hình.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_18.png",
    Code = @"\begin{tikzpicture}[scale=.7]
\tkzDefPoints{-1.5/0/O',0/0/A, 3.5/0.5/B, 4.5/2/C,1.5/3/M}
\coordinate (D) at ($(A)+(C)-(B)$);
\coordinate (I) at ($(A)!0.5!(C)$);
\coordinate (K) at ($(M)!1.36!(I)$);
\coordinate (L) at ($(M)!1.6!(I)$);
\draw (A)--(B)--(C)--(D)--(A) (M)--(I) (K)--(L);
\draw [dashed] (I)--(K);
\tkzMarkAngles[size=1.2cm](B,A,D)
\tkzDrawPoint[size=4](I)
\coordinate (A') at ($(A)+(0.55,0.35)$);
\draw (A') node {$\alpha$};
\draw (M) node[below right] {$m$};
\tkzDefPoints{5/0/A, 8.5/0/B, 9.5/1.5/C}
\coordinate (D) at ($(A)+(C)-(B)$);
\coordinate (I) at ($(A)!0.5!(C)$);
\coordinate (M) at ($(I)+(0,2.2)$);
\coordinate (K) at ($(M)!1.3!(I)$);
\coordinate (L) at ($(M)!1.6!(I)$);
\draw (A)--(B)--(C)--(D)--(A) (M)--(I) (K)--(L);
\draw [dashed] (I)--(K);
\tkzMarkAngles[size=1.2cm](B,A,D)
\tkzDrawPoint[size=4](I)
\coordinate (A') at ($(A)+(0.68,0.3)$);
\draw (A') node {$\beta$};
\draw (M) node[below right] {$n$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 19,
    Title = "Hình chóp với đường thẳng vuông góc",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình chóp ABCD.C' với đường thẳng vuông góc từ M xuống mặt đáy, các đoạn thẳng a và b.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_19.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/A,-1/1.5/B,3/1.5/C,0/5/C', 0/3.5/b,2/0.5/a}
\coordinate (D) at ($(A)+(C)-(B)$);
\coordinate (D') at ($(A)+(C')-(B)$);
\coordinate (M) at ($(A)!0.6!(B)$);
\tkzInterLL(C,B)(A,D')\tkzGetPoint{I}
\tkzInterLL(M,a)(A,D')\tkzGetPoint{N}
\tkzDrawSegments(A,D I,C C,D b,M N,a)
\tkzDrawSegments[dashed](B,I M,N)
\tkzDrawPolygon(A,B,C',D')
\tkzMarkRightAngle[size=0.2](b,M,A)
\tkzMarkRightAngle[size=0.2](a,M,A)
\tkzMarkAngles[size=0.7cm,arc=l](B,C',D')
\tkzLabelAngles[pos=0.4,rotate=10](B,C',D'){\scriptsize$\beta$}
\tkzMarkAngles[size=0.7cm,arc=l](C,D,A)
\tkzLabelAngles[pos=0.4,rotate=10](C,D,A){\scriptsize$\alpha$}
\tkzDrawPoints[size=5,fill=black](M)
\tkzLabelPoints[below left](M)
\tkzLabelPoints[above](a)
\tkzLabelPoints[above right](b)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 20,
    Title = "Hình hộp chữ nhật trong không gian",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình hộp chữ nhật ABCD.A'B'C'D' với các đỉnh và cạnh được ký hiệu rõ ràng.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_20.png",
    Code = @"\begin{tikzpicture}[scale=0.7,line join=round,line cap=round]
\tkzDefPoints{0/0/A,1.2/-1.5/B,4/0/C}
\coordinate (S) at ($(A)+(0,3)$);
\coordinate (I) at ($(C)!0.6!(B)$);
\tkzDrawPolygon(S,A,B,C)
\tkzDrawSegments(S,B S,I)
\tkzDrawSegments[dashed](A,C A,I)
\tkzDrawPoints[fill=black,size=4](A,B,C,S)
\tkzMarkRightAngle[size=0.3,fill=gray!20](A,I,B)
\tkzMarkRightAngle[size=0.3,fill=gray!20](S,I,C)
\tkzMarkAngles[size=0.7,arc=ll,mark=|](S,I,A)
\tkzLabelPoints[above](S)
\tkzLabelPoints[below](B,I)
\tkzLabelPoints[left](A)
\tkzLabelPoints[right](C)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 21,
    Title = "Hình bình hành với đường vuông góc",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành ABCD với lăng trụ trên đỉnh A'B', điểm I là trung điểm AB, đường thẳng a vuông góc với I, góc α và β.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_21.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=1, line join = round, line cap = round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzInit[xmin=0,xmax=4.7,ymin=0,ymax=3]
\tkzClip
%\tkzAxeXY
\tkzDefPoints{0/0/A,3/0/D,1.7/1/B}
\coordinate (C) at ($(B)+(D)-(A)$);
\coordinate (A') at ($(A)+(0,2)$);
\coordinate (B') at ($(B)+(A')-(A)$);
\coordinate (I) at ($(A)!0.5!(B)$);
\coordinate (a) at ($(I)+(0,1.6)$);
\tkzMarkRightAngles[size=0.2](a,I,B)
\tkzMarkAngles[size=0.4cm,arc=l](C,D,A)
\tkzMarkAngles[size=0.6cm,arc=l](A',B',B)
\tkzLabelAngles[pos=0.2,rotate=0](C,D,A){\footnotesize $\beta$ }
\tkzLabelAngles[pos=0.4,rotate=0](A',B',B){\footnotesize $\alpha$}
\tkzDrawSegments(A,B B,C C,D D,A A,A' B,B' I,a A',B')
\tkzDrawPoints[fill=black](I)
%\pgfresetboundingbox
\tkzLabelPoints[right](a)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 22,
    Title = "Góc giữa hai đường thẳng d và d'",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành MNPQ với góc α, hai đường thẳng d và d', điểm A và H, góc φ giữa d và d'.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_22.png",
    Code = @"\begin{tikzpicture}[scale=0.7,scale=0.9]
\tikzset{label style/.style={font=\scriptsize}}
\tkzInit[ymin=-5,ymax=0.5,xmin=-4.1,xmax=4.1]
\tkzClip %cắt bớt phần ko gian dư
\tkzDefPoints{-4/-4/M, -2/-1.5/Q, 2/-4/N, -0.5/-3/H}
\tkzDefPointBy[translation = from M to N](Q) \tkzGetPoint{P}%phép tịnh tiến biến Q thành P
\tkzDefLine[perpendicular=through H,K=0.4](Q,P) \tkzGetPoint{h}%đường qua H vuông góc QP
\tkzInterLL(H,h)(Q,P) \tkzGetPoint{h_1}
\coordinate[label={above right}:$A$] (A) at ($(h_1)+(0,1)$);
\tkzDefLine[parallel=through H](Q,P) \tkzGetPoint{x}%đường qua H song song MQ
\coordinate[label={above right}:$O$] (O) at ($(H)!0.4!(x)$);
\tkzInterLL(A,O)(N,P) \tkzGetPoint{O_1}
\tkzInterLL(A,O)(P,Q) \tkzGetPoint{O_3}
\coordinate (O_2) at ($(O)!3.3!(O_1)$);
\tkzLabelPoints[below](H)
\tkzDrawLines[add=0 and 0.3](O,H O,A)
\tkzDrawSegments[dashed](h_1,O_3 O,O_1)
\tkzDrawSegments(M,N N,P P,O_3 h_1,Q Q,M A,H O_1,O_2)
\tkzLabelLine[below left,pos=1.3](O,A){$d$}
\tkzLabelLine[above,pos=1.3](O,H){$d'$}
\tkzMarkRightAngle(A,H,O)
\tkzMarkAngles[arc=l,size=0.7cm](A,O,H)
\tkzLabelAngle[pos=0.9](A,O,H){$\varphi$}
\tkzMarkAngles[arc=l,size=1.1cm](N,M,Q)
\tkzLabelAngle[pos=0.7](N,M,Q){$\alpha$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 23,
    Title = "Hình chiếu của đoạn thẳng lên mặt phẳng",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành MNPQ với đoạn thẳng b và hình chiếu b' lên mặt phẳng, A, B, A', B', góc α, đường thẳng a.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_23.png",
    Code = @"\begin{tikzpicture}[font=\footnotesize, line join=round, line cap=round,>=stealth,scale=0.6]
\tkzInit[ymin=-4.1,ymax=1.6,xmin=-4.1,xmax=4.1]
\tkzClip %cắt bớt phần ko gian dư
\tkzDefPoints{-4/-4/M, -2/-1/Q, 2/-4/N, -1/-2.5/A', 2.2/-2.5/B'}
\tkzDefPointBy[translation = from M to N](Q) \tkzGetPoint{P}%phép tịnh tiến biến Q thành P
\tkzDefLine[perpendicular=through A',K=0.4](Q,P) \tkzGetPoint{m}%đường qua A' vuông góc QP
\tkzInterLL(A',m)(Q,P) \tkzGetPoint{m_1}
\tkzDefLine[perpendicular=through B',K=0.4](Q,P) \tkzGetPoint{n}%đường qua B' vuông góc QP
\tkzInterLL(B',n)(Q,P) \tkzGetPoint{n_1}
\coordinate[label={above}:$A$] (A) at ($(m_1)+(0,1)$);
\coordinate[label={above}:$B$] (B) at ($(n_1)+(0,2)$);
\coordinate (H) at ($(A')!0.3!(B')$);
\tkzDefLine[parallel=through H](M,Q) \tkzGetPoint{x}%đường qua H song song MQ
\coordinate (H_1) at ($(H)!0.4!(x)$);
\coordinate[label={right}:$a$] (H_2) at ($(H)!-0.4!(x)$);
\tkzLabelPoints[below](A',B')
\tkzDrawSegments[dashed](m_1,n_1 H,H_1)
\tkzDrawLines(A,B A',B')
\tkzDrawSegments(M,N N,P P,n_1 m_1,Q Q,M H_2,H A,A' B,B')
\tkzLabelSegment[above,pos=0.7](A',B'){$b'$}
\tkzLabelSegment[above,pos=0.4](A,B){$b$}
\tkzMarkRightAngle(H_2,H,B')
\tkzMarkAngles[arc=l,size=1.1cm](N,M,Q)
\tkzLabelAngle[pos=0.7](N,M,Q){$\alpha$}
\tkzDrawPoints[fill=black](A,B,A',B')
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 24,
    Title = "Đường thẳng d song song với Δ",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành ABCD với góc α, đường thẳng Δ và đường thẳng d song song với Δ, EF là đoạn thẳng vuông góc.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_24.png",
    Code = @"\begin{tikzpicture}[scale=0.9]
\tkzDefPoints{0/0/A, 5/0/B, 6/2/C, 1/2/D, 2.5/1/E, 2.5/3/F, 2.5/0/G, 3/0.5/M, 4.5/1.5/N, 3/1.5/P, 4.5/0.5/Q}
\draw (4.5,1.5) node[right] {\footnotesize d};
\draw (2.5,3) node[right] {\footnotesize $\Delta$};
\tkzDrawSegments(A,B B,C C,D D,A E,F M,N)
\tkzDrawSegments[dashed](E,G)
\tkzMarkAngles[size=0.7cm,arc=l](B,A,D)
\tkzLabelAngles[pos=0.4,rotate=10](B,A,D){\scriptsize $\alpha$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 25,
    Title = "Hai đường thẳng song song Δ và d",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành ABCD với góc α, đường thẳng Δ và d song song nhau, EF vuông góc với cả hai.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_25.png",
    Code = @"\begin{tikzpicture}[scale=0.9]
\tkzDefPoints{0/0/A, 5/0/B, 6/2/C, 1/2/D, 2.5/1/E, 2.5/3/F, 2.5/0/G, 3/0.5/M, 4.5/1.5/N, 3/1.5/P, 4.5/0.5/Q, 4.5/3/R, 4.5/-0.2/S}
\draw (2.5,3) node[right] {\footnotesize $\Delta$};
\draw (4.5,3) node[right] {\footnotesize $d$};
\tkzDrawSegments(A,B B,C C,D D,A E,F Q,R)
\tkzDrawSegments[dashed](E,G Q,S)
\tkzMarkAngles[size=0.8cm,arc=l](B,A,D)
\tkzLabelAngles[pos=0.45,rotate=10](B,A,D){\scriptsize$\alpha$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 26,
    Title = "Đường thẳng a và b vuông góc trong không gian",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành ABCD với góc α, đường thẳng a nằm trong mặt phẳng trên, đường thẳng b vuông góc với mặt đáy tại tâm O.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_26.png",
    Code = @"\begin{tikzpicture}[scale=0.9, line join=round, line cap=round]
\tkzDefPoints{0/0/A,5/0/B,6.5/2/C, 3/1/O}
\draw (1,3)--(6,3)node[above]{$a$};
\coordinate (D) at ($(A)+(C)-(B)$);
\coordinate (b) at ($(O)+(0,2.5)$);
\coordinate (b') at ($(O)+(0,-2.5)$);
\tkzInterLL(b,b')(A,B)\tkzGetPoint{I}
\tkzDrawSegments(b,O I,b')
\tkzDrawSegments[dashed](O,I)
\tkzDrawPolygon(A,B,C,D)
\tkzLabelPoints[left](b)
\tkzMarkAngles[size=0.7cm,arc=l](B,A,D)
\tkzLabelAngles[pos=0.4,rotate=10](B,A,D){\scriptsize $\alpha$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 27,
    Title = "Hình chiếu đoạn thẳng b lên mặt phẳng (dạng nhỏ)",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Tương tự item 23, hình bình hành MNPQ với đoạn b và hình chiếu b', A, B, A', B', góc α, đường a (kích thước nhỏ hơn).",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_27.png",
    Code = @"\begin{tikzpicture}[font=\footnotesize, line join=round, line cap=round,>=stealth,scale=0.5]
\tikzset{label style/.style={font=\footnotesize}}
\tkzInit[ymin=-4.1,ymax=1.6,xmin=-4.1,xmax=4.1]
\tkzClip %cắt bớt phần ko gian dư
\tkzDefPoints{-4/-4/M, -2/-1/Q, 2/-4/N, -1/-2.5/A', 2.2/-2.5/B'}
\tkzDefPointBy[translation = from M to N](Q) \tkzGetPoint{P}%phép tịnh tiến biến Q thành P
\tkzDefLine[perpendicular=through A',K=0.4](Q,P) \tkzGetPoint{m}%đường qua A' vuông góc QP
\tkzInterLL(A',m)(Q,P) \tkzGetPoint{m_1}
\tkzDefLine[perpendicular=through B',K=0.4](Q,P) \tkzGetPoint{n}%đường qua B' vuông góc QP
\tkzInterLL(B',n)(Q,P) \tkzGetPoint{n_1}
\coordinate[label={above}:$A$] (A) at ($(m_1)+(0,1)$);
\coordinate[label={above}:$B$] (B) at ($(n_1)+(0,2)$);
\coordinate (H) at ($(A')!0.3!(B')$);
\tkzDefLine[parallel=through H](M,Q) \tkzGetPoint{x}%đường qua H song song MQ
\coordinate (H_1) at ($(H)!0.4!(x)$);
\coordinate[label={right}:$a$] (H_2) at ($(H)!-0.4!(x)$);
\tkzLabelPoints[below](A',B')
\tkzDrawSegments[dashed](m_1,n_1 H,H_1)
\tkzDrawLines(A,B A',B')
\tkzDrawSegments(M,N N,P P,n_1 m_1,Q Q,M H_2,H A,A' B,B')
\tkzLabelSegment[above,pos=0.7](A',B'){$b'$}
\tkzLabelSegment[above,pos=0.4](A,B){$b$}
\tkzMarkRightAngle(H_2,H,B')
\tkzMarkAngles[arc=l,size=1.1cm](N,M,Q)
\tkzLabelAngle[pos=0.7](N,M,Q){$\alpha$}
\tkzDrawPoints[fill=black](A,B,A',B')
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 28,
    Title = "Góc giữa hai đường thẳng với điểm A, H, O",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Tương tự item 22, hình bình hành MNPQ với góc α, hai đường thẳng d và d', các điểm A, H, O, góc φ (có thêm điểm cụ thể).",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_28.png",
    Code = @"\begin{tikzpicture}[font=\footnotesize, line join=round, line cap=round,>=stealth,scale=0.6]
\tikzset{label style/.style={font=\footnotesize}}
\tkzInit[ymin=-5,ymax=0.5,xmin=-4.1,xmax=4.1]
\tkzClip %cắt bớt phần ko gian dư
\tkzDefPoints{-4/-4/M, -2/-1.5/Q, 2/-4/N, -0.5/-3/H}
\tkzDefPointBy[translation = from M to N](Q) \tkzGetPoint{P}%phép tịnh tiến biến Q thành P
\tkzDefLine[perpendicular=through H,K=0.4](Q,P) \tkzGetPoint{h}%đường qua H vuông góc QP
\tkzInterLL(H,h)(Q,P) \tkzGetPoint{h_1}
\coordinate[label={above right}:$A$] (A) at ($(h_1)+(0,1)$);
\tkzDefLine[parallel=through H](Q,P) \tkzGetPoint{x}%đường qua H song song MQ
\coordinate[label={above right}:$O$] (O) at ($(H)!0.4!(x)$);
\tkzInterLL(A,O)(N,P) \tkzGetPoint{O_1}
\tkzInterLL(A,O)(P,Q) \tkzGetPoint{O_3}
\coordinate (O_2) at ($(O)!3.3!(O_1)$);
\tkzLabelPoints[below](H)
\tkzDrawLines[add=0 and 0.3](O,H O,A)
\tkzDrawSegments[dashed](h_1,O_3 O,O_1)
\tkzDrawSegments(M,N N,P P,O_3 h_1,Q Q,M A,H O_1,O_2)
\tkzLabelLine[below left,pos=1.3](O,A){$d$}
\tkzLabelLine[above,pos=1.3](O,H){$d'$}
\tkzMarkRightAngle(A,H,O)
\tkzMarkAngles[arc=l,size=0.7cm](A,O,H)
\tkzLabelAngle[pos=0.9](A,O,H){$\varphi$}
\tkzMarkAngles[arc=l,size=1.1cm](N,M,Q)
\tkzLabelAngle[pos=0.7](N,M,Q){$\alpha$}
\tkzDrawPoints[fill=black](A,H,O)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 29,
    Title = "Hai đường thẳng a và b trong không gian",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành ABCD với góc α, đường thẳng Δ, hai đường thẳng a và b trong không gian, EF vuông góc.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_29.png",
    Code = @"\begin{tikzpicture}[scale=0.9]
\tkzDefPoints{0/0/A, 5/0/B, 6/2/C, 1/2/D, 2.5/1/E, 2.5/3/F, 2.5/0/G, 3/0.5/M, 4.5/1.5/N, 3/1.5/P, 4.5/0.5/Q}
\draw (4.5,1.5) node[right] {\footnotesize a};
\draw (4.5,0.5) node[right] {\footnotesize b};
\draw (2.5,3) node[right] {\footnotesize $\Delta$};
\tkzDrawSegments(A,B B,C C,D D,A E,F M,N P,Q)
\tkzDrawSegments[dashed](E,G)
\tkzMarkAngles[size=0.8cm,arc=l](B,A,D)
\tkzLabelAngles[pos=0.45,rotate=10](B,A,D){\scriptsize$\alpha$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 30,
    Title = "Lăng trụ với hai mặt đáy song song",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Lăng trụ ABCD.A'B'C'D' với đường thẳng a vuông góc cạnh AB, góc α và β giữa hai mặt đáy, điểm O.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_30.png",
    Code = @"\begin{tikzpicture}[font=\footnotesize, line join=round, line cap=round,>=stealth,scale=0.9]
\tkzInit[ymin=-3.6,ymax=1.6,xmin=-4.1,xmax=2.6]
\tkzClip %cắt bớt phần ko gian dư
\tkzDefPoints{-4/-3/A, 1/-3/B, -2.5/-1.5/C, 0/-2/O}
\tkzDefPointBy[translation = from A to B](C) \tkzGetPoint{D}%phép tịnh tiến
\coordinate (A') at ($(A)+(0,2)$);
\tkzDefPointBy[translation = from A to B](A') \tkzGetPoint{B'}
\tkzDefPointBy[translation = from A to C](A') \tkzGetPoint{C'}
\tkzDefPointBy[translation = from A to B](C') \tkzGetPoint{D'}
\tkzDefLine[perpendicular=through O,K=0.8](A,B) \tkzGetPoint{d}%đường qua O vuông góc AB
\tkzInterLL(O,d)(A,B) \tkzGetPoint{d_1}
\tkzInterLL(O,d)(A',B') \tkzGetPoint{d_2}
\coordinate (O') at ($(d_2)+(0,1)$);
\coordinate[label={below left}:$a$] (O'_1) at ($(O')+(0,1.5)$);
\coordinate (O_1) at ($(O)+(0,-1.5)$);
\tkzDrawSegments[dashed](d_1,O d_2,O')
\tkzDrawSegments(A,B B,D D,C C,A A',B' B',D' D',C' C',A' O_1,d_1 O,d_2 O',O'_1)
\tkzMarkAngles[arc=l,size=1.1cm](B,A,C B',A',C')
\tkzLabelAngle[pos=0.7](B,A,C){$\beta$}
\tkzLabelAngle[pos=0.7](B',A',C'){$\alpha$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 31,
    Title = "Hai đường thẳng song song a và b cắt mặt phẳng",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành ABCD với hai đường thẳng song song a và b, góc α, các điểm I, J, K, P.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_31.png",
    Code = @"\begin{tikzpicture}[font=\footnotesize, line join=round, line cap=round,>=stealth,scale=0.7]
\tkzDefPoints{0/0/A, 5/0/B, 6/3/C, 2/1.5/I, 4/1.5/J, 2/4/K}
\tkzDefPointBy[translation = from B to C](A)
\tkzGetPoint{D}
\tkzDefPointBy[symmetry = center I](K)
\tkzGetPoint{P}
\tkzDefPointBy[translation = from I to J](K)
\tkzGetPoint{K'}
\tkzDefPointBy[translation = from I to J](P)
\tkzGetPoint{P'}
\tkzInterLL(A,B)(K,P)
\tkzGetPoint{Q}
\tkzInterLL(A,B)(K',P')
\tkzGetPoint{Q'}
\tkzDrawSegments[dashed](I,Q J,Q')
\tkzDrawSegments(A,B B,C C,D D,A K,I Q,P K',J Q',P')
\tkzMarkAngle[size=.85](B,A,D)
\draw (A) node [above right] {$\alpha$};
\draw ($(K)$) node [below left] {$a$};
\draw ($(K')$) node [below left] {$b$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 32,
    Title = "Hình bình hành với đường thẳng d và điểm O",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành ABCD với góc α, đường thẳng d đi qua điểm O nằm trong không gian.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_32.png",
    Code = @"\begin{tikzpicture}[scale=1.5,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/A, 1/1/B, 3/0/D, 2/2/m1}
\coordinate (C) at ($(D)+(B)-(A)$);
\draw (A)--(B)--(C)--(D)--cycle;
\tkzMarkAngle[size=.5](D,A,B)
\draw (0.06,-0.07) node[above right]{$\alpha$};
\coordinate (m2) at ($(m1)-(0,2.2)$);
\draw (m1) node[right]{$d$};
\tkzInterLL(B,C)(m1,m2) \tkzGetPoint{m3}
\coordinate (m4) at ($(m1)!0.6!(m2)$); 
\tkzInterLL(A,D)(m1,m2) \tkzGetPoint{m5}
\tkzDrawSegments[thick](m1,m4 m2,m5)
\tkzDrawSegments[dashed](m4,m5)
\coordinate (e1) at ($(A)!0.8!(B)$);
\coordinate (e2) at ($(A)!0.6!(D)$);
\coordinate (O) at ($(m1)!0.3!(m2)$);
\tkzDrawPoints[size=1.5,fill=black](O)
\tkzLabelPoints[left](O)
\tkzDrawPoints[fill=black](O)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 33,
    Title = "Hình chữ nhật EFGH với đoạn vuông góc",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình chữ nhật EFGH với các điểm A, B, I, M, đoạn thẳng MB vuông góc với I, trong không gian ba chiều.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_33.png",
    Code = @"\begin{tikzpicture}[font=\footnotesize, line join=round, line cap=round,>=stealth,xscale=0.8,yscale=0.6]
\tkzDefPoints{0/0/E, 3/1/F, 0/5/H, 2/4.5/M, 1/2/I, -2/2/A}%điểm A ngay góc alpha, G ngay góc beta
\tkzDefPointBy[translation = from E to H](F)
\tkzGetPoint{G}
\tkzDefPointBy[symmetry = center I](A)
\tkzGetPoint{B}
\tkzInterLL(F,G)(M,B)
\tkzGetPoint{C}
\tkzInterLL(F,G)(I,B)
\tkzGetPoint{D}
\tkzInterLL(E,H)(M,A)
\tkzGetPoint{J}
\tkzInterLL(E,H)(I,A)
\tkzGetPoint{K}
\tkzDrawPoints[fill=black](A,B,I,M)
\tkzLabelPoints[below](A,B,I)
\tkzLabelPoints[above](M)
\tkzDrawSegments(E,F F,D C,G G,H H,E M,I M,B B,I A,K A,J)
\tkzDrawSegments[dashed](M,J I,K C,D)
\tkzMarkRightAngle[size=.2](M,I,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 34,
    Title = "Hai đường thẳng vuông góc a, b và d",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Đường thẳng d vuông góc với đường thẳng a tại O và vuông góc với đường thẳng b tại M.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_34.png",
    Code = @"\begin{tikzpicture}[scale=0.6]
\tkzDefPoints{0/0/O,-3/0/a,1.5/0/A,-4/1.2/b,0/1.2/M,1/1.2/B,0/-1/D,0/3/d}
\tkzDrawSegments(d,D a,A b,B)
\tkzDrawPoints(O,M)
\tkzLabelPoints[above left](d)
\tkzLabelPoints[above right](a,b)
\tkzMarkRightAngle(d,O,a)
\tkzMarkRightAngle(d,M,b)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 35,
    Title = "Hình bình hành với đường thẳng d và a",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành ABCD với góc α, đường thẳng d vuông góc mặt đáy, đường thẳng a nằm trong mặt đáy.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_35.png",
    Code = @"\begin{tikzpicture}[scale=1.2,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/A, 1/1/B, 3/0/D, 2/2/m1}
\coordinate (C) at ($(D)+(B)-(A)$);
\draw (A)--(B)--(C)--(D)--cycle;
\tkzMarkAngle[size=.5](D,A,B)
\draw (0.06,-0.07) node[above right]{$\alpha$};
\coordinate (m2) at ($(m1)-(0,2.2)$);
\draw (m1) node[right]{$d$};
\tkzInterLL(B,C)(m1,m2) \tkzGetPoint{m3}
\coordinate (m4) at ($(m1)!0.6!(m2)$); 
\tkzInterLL(A,D)(m1,m2) \tkzGetPoint{m5}
\tkzDrawSegments(m1,m4 m2,m5)
\tkzDrawSegments[dashed](m4,m5)
\coordinate (e1) at ($(A)!0.8!(B)$);
\coordinate (e2) at ($(A)!0.6!(D)$);
\tkzDrawLines[add = -0.15 and -0.15](e1,e2)
\coordinate (e3) at ($(e1)!0.25!(e2)$);
\draw (e3) node[above,rotate=-30]{$a$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 36,
    Title = "Hình bình hành với hai đường thẳng a, b và điểm O",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành ABCD với góc α, đường thẳng d vuông góc, hai đường thẳng a và b cắt nhau tại O trong mặt đáy.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_36.png",
    Code = @"\begin{tikzpicture}[scale=1.5,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/A, 1/1.5/B, 3/0/D, 2.5/2/m1}
\coordinate (C) at ($(D)+(B)-(A)$);
\draw (A)--(B)--(C)--(D)--cycle;
\tkzMarkAngle[size=.5](D,A,B)
\draw (0.06,-0.06) node[above right]{$\alpha$};
\coordinate (m2) at ($(m1)-(0,2.2)$);
\draw (m1) node[left]{$d$};
\tkzInterLL(B,C)(m1,m2) \tkzGetPoint{m3}
\coordinate (m4) at ($(m1)!0.5!(m2)$); 
\tkzInterLL(D,A)(m1,m2) \tkzGetPoint{m5}
\draw (m1)--(m4);
\draw[dashed] (m4)--(m5);
\tkzDrawLines[add = 2 and -0.1](m2,m5)
\coordinate (m6) at ($(m1)!0.15!(m2)$); 
\coordinate (e1) at ($(A)!0.8!(B)$);
\coordinate (e2) at ($(A)!0.75!(D)$);
\coordinate (e3) at ($(e1)!0.2!(e2)$);
\coordinate (e4) at ($(e1)!0.8!(e2)$);
\draw (e3) node[above, rotate=-30]{$a$};
\tkzDrawLines[add = -0.15 and -0.1](e1,e2)
%vecto n
\coordinate (e5) at ($(B)!0.6!(C)$); 
\tkzDrawLines[add = -0.25 and -0.14](A,e5)
\coordinate (e6) at ($(A)!0.3!(e5)$);
\coordinate (e7) at ($(A)!0.74!(e5)$);
\draw (e6) node[above, rotate=30]{$b$};
\tkzInterLL(e1,e2)(A,e5) \tkzGetPoint{O}
\tkzDrawPoints[fill=black](O)
\tkzLabelPoints[below](O)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 37,
    Title = "Hình bình hành với đường thẳng d và điểm O",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành ABCD với góc α, đường thẳng d cắt mặt phẳng, điểm O nằm trong mặt đáy.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_37.png",
    Code = @"\begin{tikzpicture}[scale=1.5,font=\footnotesize, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/A, 1/1/B, 3/0/D, 2.5/2/m1}
\coordinate (C) at ($(D)+(B)-(A)$);
\draw (A)--(B)--(C)--(D)--cycle;
\tkzMarkAngle[size=.5](D,A,B)
\draw (0.06,-0.07) node[above right]{$\alpha$};
\coordinate (m2) at ($(m1)-(0,2.2)$);
\draw (m1) node[right]{$d$};
\tkzInterLL(B,C)(m1,m2) \tkzGetPoint{m3}
\coordinate (m4) at ($(m1)!0.6!(m2)$); 
\tkzInterLL(A,D)(m1,m2) \tkzGetPoint{m5}
\tkzDrawSegments[thick](m1,m4 m2,m5)
\tkzDrawSegments[dashed](m4,m5)
\coordinate (e1) at ($(A)!0.8!(B)$);
\coordinate (e2) at ($(A)!0.6!(D)$);
\coordinate (O) at ($(e1)!0.5!(e2)$);
\tkzDrawPoints[size=1.5,fill=black](O)
\tkzLabelPoints[above](O)
\tkzDrawPoints[fill=black](O)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 38,
    Title = "Hai đường thẳng a và b vuông góc tại O",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hai đường thẳng a và b vuông góc nhau tại điểm O (hình đơn giản).",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_38.png",
    Code = @"\begin{tikzpicture}[scale=0.6]
\tkzDefPoints{0/0/O,-2/0/a,0.5/0/A,0/-0.5/B,0/2/b}
\tkzDrawSegments(a,A b,B)
\tkzDrawPoints(O)
\tkzLabelPoints[above right](a,b)
\tkzMarkRightAngle(b,O,a)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 39,
    Title = "Lăng trụ với hai đường thẳng song song a và b",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Lăng trụ ABCD.A'B'C'D' với hai đường thẳng song song a và b, các góc P, Q, R giữa các mặt phẳng.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_39.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=.5]
\clip (-2,-3) rectangle (10,8.5);
\tkzDefPoints{0/0/B, 6/0/C, 9/2/D, 3/2/A}
\coordinate (A') at ($(A)+(0,3)$);
\coordinate (B') at ($(B)+(0,3)$);
\coordinate (C') at ($(C)+(0,3)$);
\coordinate (D') at ($(D)+(0,3)$);
\coordinate (M) at ($(A)!0.55!(D)$);
\coordinate (N) at ($(B)!0.55!(C)$);
\coordinate (P) at ($(B')!0.55!(C')$);
\coordinate (Q) at ($(A')!0.55!(D')$);
\coordinate (M') at ($(M)-(0,3)$);
\coordinate (N') at ($(N)-(0,3)$);
\coordinate (P') at ($(P)+(0,3)$);
\coordinate (Q') at ($(Q)+(0,3)$);
\tkzInterLL(P',N')(A',D')
\tkzGetPoint{K}
\tkzInterLL(P',N')(A,D)
\tkzGetPoint{K'}
\tkzInterLL(Q',M')(A',D')
\tkzGetPoint{L}
\tkzInterLL(Q',M')(C',D')
\tkzGetPoint{L1}
\tkzInterLL(Q',M')(C,D)
\tkzGetPoint{L2}
\tkzInterLL(Q',M')(A,D)
\tkzGetPoint{L'}
\tkzDrawSegments(A,B B,C C,D D,L' A,K')
\tkzDrawSegments[dashed](L',K')
\tkzDrawSegments(A',B' B',C' C',D' D',L A',K)
\tkzDrawSegments[dashed](K,L)
\tkzDrawSegments(M',N' N',P' P',Q' Q',L M',L2 L1,L')
\tkzDrawSegments[dashed](L,L1 L',L2)
\tkzDrawSegments(M,N P,Q)
\tkzLabelSegment[left](M,N){$a$}
\tkzLabelSegment[left](P,Q){$b$}
%\tkzLabelSegment[blue](B,N){$P$}
%\tkzLabelSegment[red](B',P){$Q$}
%\tkzLabelSegment[black](Q,P'){$R$}
\tkzLabelAngle[pos=1.25,rotate=30](A',B',C'){\footnotesize $Q$}
\tkzMarkAngle[size =1.6,opacity=1](C',B',A');
\tkzLabelAngle[pos=1.25,rotate=30](A,B,C){\footnotesize $P$}
\tkzMarkAngle[size =1.6,opacity=1](C,B,A);
\tkzLabelAngle[pos=1.15,rotate=30](M',Q',P'){\footnotesize $R$}
\tkzMarkAngle[size =1.6,opacity=1](P',Q',M');
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 40,
    Title = "Ba đường thẳng song song a, b, c",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành A'B'C'D' với góc α, ba đường thẳng song song a, b, c trong không gian.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_40.png",
    Code = @"\begin{tikzpicture}[scale=1]
\tkzDefPoints{0/0/A', 4/0/B', 1/2/D', 1/1/A, 4/1/B, 0/2.5/M, 1/.5/P, 4/1.75/Q}
\coordinate (C') at ($(B')+(D')-(A')$);
\tkzDefPointBy[translation = from A' to B'](M) \tkzGetPoint{N}
\tkzLabelSegment[pos=.3](M,N){ $a$}
\tkzLabelSegment[pos=.9](A,B){ $c$}
\tkzLabelSegment[pos=.1, below](P,Q){ $b$}
%\tkzDrawSegments[dashed](A,A' A',B' A',C')
\tkzDrawPolygon(A',B',C',D')
\tkzDrawSegments(A,B M,N P,Q)
%\tkzLabelPoints[right](B)
%\tkzLabelPoints[above](A,B)
\tkzMarkAngles[size=.7](B',A',D')
\tkzLabelAngle[pos=0.4](D',A',B'){\footnotesize $\alpha$ }
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 41,
    Title = "Hai đường thẳng song song a và b",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành A'B'C'D' với góc α, hai đường thẳng song song a và b trong không gian.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_41.png",
    Code = @"\begin{tikzpicture}[scale=1]
\tkzDefPoints{0/0/A', 4/0/B', 1/2/D', 1/1/A, 4/1/B, 0/2.5/M}
\coordinate (C') at ($(B')+(D')-(A')$);
\tkzDefPointBy[translation = from A' to B'](M) \tkzGetPoint{N}
\tkzLabelSegment[pos=.3](M,N){ $a$}
\tkzLabelSegment[pos=.3](A,B){ $b$}
%\tkzDrawSegments[dashed](A,A' A',B' A',C')
\tkzDrawPolygon(A',B',C',D')
\tkzDrawSegments(A,B M,N)
%\tkzLabelPoints[right](B)
%\tkzLabelPoints[above](A,B)
\tkzMarkAngles[size=.7](B',A',D')
\tkzLabelAngle[pos=0.4](D',A',B'){\footnotesize $\alpha$ }
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 42,
    Title = "Đường thẳng a cắt mặt phẳng P",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành A'B'C'D' với góc P, đường thẳng a cắt mặt phẳng tại điểm A, các giao điểm I và J.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_42.png",
    Code = @"\begin{tikzpicture}[scale=.8]
\tkzDefPoints{0/0/A', 4/0/B', 1/2/D', 2/1/A, 0/2.5/B}
\coordinate (C') at ($(B')+(D')-(A')$);
\tkzLabelSegment[pos=.9](A,B){ $a$}
\tkzInterLL(A,B)(A',B')\tkzGetPoint{I}
\tkzInterLL(A,B)(C',B')\tkzGetPoint{J}
\tkzDrawPolygon(A',B',C',D')
\tkzDrawSegments(A,B I,J)
\tkzDrawSegments[dashed](A,I)
%\tkzLabelPoints[right](B)
\tkzLabelPoints[above right](A)
\tkzMarkAngles[size=1](B',A',D')
\tkzLabelAngle[pos=0.6](D',A',B'){\footnotesize $P$ }
\tkzDrawPoints(A)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 43,
    Title = "Hai hình bình hành song song với đường thẳng a",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hai hình bình hành MNPQ với góc P và góc Q, đường thẳng a song song với cả hai mặt phẳng.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_43.png",
    Code = @"\begin{tikzpicture}[font=\footnotesize,yscale=0.8]
\tkzDefPoints{0/0/m,1/1.5/n,4.5/1.5/p,3.5/0/q,0/-2/a,1/-0.5/b,4.5/-0.5/c,3.5/-2/d}
\draw (m)--(n)--(p)--(q)--(m);
\tkzMarkAngle[size=0.9](q,m,n)
\draw (1,2)--(4.5,2) node[above left] {$a$};
\tkzLabelAngle[pos=0.6](q,m,n){P}
\draw (a)--(b)--(c)--(d)--(a);
\tkzMarkAngle[size=0.9](d,a,b)
\tkzLabelAngle[pos=0.6](d,a,b){Q}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 44,
    Title = "Hình chóp với hai đường thẳng song song a và b - Hình 1",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình chóp ABCD.PQ với hai đường thẳng song song a và b, góc α và β giữa các mặt phẳng (Hình 1).",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_44.png",
    Code = @"\begin{tikzpicture}[font=\footnotesize,scale=0.9]
\tkzDefPoints{0/0/a, 2/1.5/b, 6/1.5/c, 4/0/d, 0.5/3/z}
\coordinate (p) at ($(a)+(z)$);
\coordinate (q) at ($(b)+(z)$);
\draw (a)--(b)--(c)--(d)--(a);
\draw (a)--(p)--(q)--(b);
\tkzDefPoints{1.5/0.3/p1, 0.5/1.5/q1}
\coordinate (p2) at ($(p1)+0.6*(b)-0.6*(a)$);
\coordinate (q2) at ($(q1)+0.75*(b)-0.75*(a)$);
\draw (p1)--(p2) node[right] {$a$};
\coordinate (q3) at ($(q1)+0.3*(z)$);
\coordinate (q4) at ($(q2)+0.3*(z)$);
\coordinate (p3) at ($(p1)+(1,0)$);
\coordinate (p4) at ($(p2)+(1,0)$);
\draw(p3)--(p4) node[right] {$b$};
\tkzMarkAngle[size=0.9](p,q,b)
\tkzLabelAngle[pos=0.6](p,q,b){$\alpha$}
\tkzMarkAngle[size=0.9](b,c,d)
\tkzLabelAngle[pos=-0.6](b,c,d){$\beta$}
\node[right] at (1,-1) {Hình 1.};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 45,
    Title = "Hình chóp với hai đường thẳng song song a và b - Hình 2",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình chóp ABCD.PQ với hai đường thẳng song song a và b, góc α và β giữa các mặt phẳng (Hình 2).",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_45.png",
    Code = @"\begin{tikzpicture}[font=\footnotesize,scale=0.9]
\tkzDefPoints{0/0/a, 0/3/b, 1.5/4/c, 1.5/1/d, 3/3/p, 3/0/q}
\draw (a)--(b)--(c)--(d)--(a);
\draw (c)--(p)--(q)--(d);
\draw (3.5,0.3)--(3.5,2.8) node[below right] {$a$} (4.3,0.3)--(4.3,2.8) node[below right] {$b$};
\tkzMarkAngle[size=0.9](d,a,b)
\tkzLabelAngle[pos=0.6](d,a,b){$\alpha$}
\tkzMarkAngle[size=0.9](p,q,d)
\tkzLabelAngle[pos=0.6](p,q,d){$\beta$}
\node[right] at (1,-1) {Hình 2.};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 46,
    Title = "Đường thẳng a song song với mặt phẳng P",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành A'B'C'D' biểu diễn mặt phẳng P, đường thẳng a song song với mặt phẳng P.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_46.png",
    Code = @"\begin{tikzpicture}[scale=.8]
\tkzDefPoints{0/0/A', 4/0/B', 1/2/D', 0/2.5/M}
\coordinate (C') at ($(B')+(D')-(A')$);
\tkzDefPointBy[translation = from A' to B'](M) \tkzGetPoint{N}
\tkzLabelSegment[pos=.3](M,N){ $a$}
%\tkzDrawSegments[dashed](A,A' A',B' A',C')
\tkzDrawPolygon(A',B',C',D')
\tkzDrawSegments(M,N)
%\tkzLabelPoints[right](B)
%\tkzLabelPoints[above](z,y)
\tkzMarkAngles[size=1](B',A',D')
\tkzLabelAngle[pos=0.6](D',A',B'){\footnotesize $P$ }
%\tkzDrawPoints(M,N,A)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 47,
    Title = "Đường thẳng a nằm trong mặt phẳng P",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành A'B'C'D' biểu diễn mặt phẳng P, đường thẳng a nằm hoàn toàn trong mặt phẳng P.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_47.png",
    Code = @"\begin{tikzpicture}[scale=.8]
\tkzDefPoints{0/0/A', 4/0/B', 1/2/D', 1/1/A, 4/1/B}
\coordinate (C') at ($(B')+(D')-(A')$);
\tkzLabelSegment[pos=.3](A,B){ $a$}
%\tkzDrawSegments[dashed](A,A' A',B' A',C')
\tkzDrawPolygon(A',B',C',D')
\tkzDrawSegments(A,B)
%\tkzLabelPoints[right](B)
%\tkzLabelPoints[above](A,B)
\tkzMarkAngles[size=1](B',A',D')
\tkzLabelAngle[pos=0.6](D',A',B'){\footnotesize $P$ }
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 48,
    Title = "Hai hình bình hành với đường thẳng a chung",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hai hình bình hành với góc P và Q, đường thẳng a song song hoặc nằm giữa hai mặt phẳng.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_48.png",
    Code = @"\begin{tikzpicture}[font=\footnotesize,yscale=0.8]
\tkzDefPoints{0/0/m,1/1.5/n,4.5/1.5/p,3.5/0/q,0/-2/a,1/-0.5/b,4.5/-0.5/c,3.5/-2/d}
\draw (m)--(n)--(p)--(q)--(m);
\tkzMarkAngle[size=0.9](q,m,n)
\draw (1,2)--(4.5,2) node[above left] {$a$};
\tkzLabelAngle[pos=0.6](q,m,n){P}
\draw (a)--(b)--(c)--(d)--(a);
\tkzMarkAngle[size=0.9](d,a,b)
\tkzLabelAngle[pos=0.6](d,a,b){Q}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 49,
    Title = "Ba hình bình hành song song",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Ba hình bình hành ABCD song song với nhau, tạo góc α và β giữa các mặt phẳng.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_49.png",
    Code = @"\begin{tikzpicture}[scale=0.4]
\tkzDefPoints{0/0/A, 9/0/B, 12/2.5/C}
\coordinate (A1) at ($(A)+(0,3)$);
\coordinate (B1) at ($(B)+(0,3)$);
\coordinate (C1) at ($(C)+(0,3)$);
\coordinate (D) at ($(A)-(B)+(C)$);
\coordinate (D1) at ($(A1)-(B1)+(C1)$);
\coordinate (A2) at ($(A)-(0,3)$);
\coordinate (B2) at ($(B)-(0,3)$);
\coordinate (C2) at ($(C)-(0,3)$);
\coordinate (D2) at ($(A2)-(B2)+(C2)$);
\tkzDrawSegments(A,B B,C C,D D,A A1,B1 B1,C1 C1,D1 D1,A1 A2,B2 B2,C2 C2,D2 D2,A2)
\tkzMarkAngles[size=1.6cm,arc=l](B,A,D)
\tkzMarkAngles[size=1.6cm,arc=l](B1,A1,D1)
\tkzMarkAngles[size=1.6cm,arc=l](B2,A2,D2)
\tkzLabelAngles[pos=1,rotate=30](B1,A1,D1){\scriptsize$\alpha$}
\tkzLabelAngles[pos=1,rotate=30](B,A,D){\scriptsize$\beta$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 50,
    Title = "Mặt phẳng α và β với điểm A",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hai hình bình hành biểu diễn mặt phẳng α và β, điểm A nằm trên mặt phẳng α.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_50.png",
    Code = @"\begin{tikzpicture}[line join = round, line cap = round,>=stealth,font=\footnotesize,scale=0.7]
\begin{scope}[shift={(0,0)}]
\tkzDefPoints{0/0/A,5/0/B,6.5/1.5/C}
\coordinate (D) at ($(A)+(C)-(B)$);
\coordinate (a) at ($(A)+(3.5,0.8)$);
\draw ($(A)+(0.5,0.2)$) node {$\alpha$};
\draw ($(a)+(0,0.2)$) node {$A$};
\tkzDrawSegments(A,B B,C C,D D,A)
\tkzMarkAngles[size=0.8cm,arc=l](B,A,D)
\tkzDrawPoints[fill=black](a)
\end{scope}
\begin{scope}[shift={(0,-2)}]
\tkzDefPoints{0/0/A,5/0/B,6.5/1.5/C}
\coordinate (D) at ($(A)+(C)-(B)$);
\draw ($(A)+(0.5,0.2)$) node {$\beta$};
\tkzDrawSegments(A,B B,C C,D D,A)
\tkzMarkAngles[size=0.8cm,arc=l](B,A,D)
\end{scope}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 51,
    Title = "Hai mặt phẳng α, β với hai đường thẳng a, b",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hai mặt phẳng α và β, hai đường thẳng a và b cắt cả hai mặt phẳng, các điểm A, A', B, B'.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_51.png",
    Code = @"\begin{tikzpicture}[line join = round, line cap = round,>=stealth,font=\footnotesize,scale=0.7]
\tkzDefPoints{0/0/A,5/0/B,6.5/1.5/C}
\coordinate (D) at ($(A)+(C)-(B)$);
\coordinate (M) at ($(A)+(0,-2.2)$);
\coordinate (N) at ($(M)+(5,0)$);
\coordinate (P) at ($(M)+(6.5,1.5)$);
\coordinate (Q) at ($(M)+(P)-(N)$);
\coordinate (a) at ($(D)+(0,1)$);
\coordinate (b) at ($(D)+(2.5,1.2)$);
\coordinate (c) at ($(M)+(2.5,-0.4)$);
\coordinate (d) at ($(M)+(5,-0.2)$);
\coordinate (A') at ($(a)!0.3!(c)$);
\coordinate (B') at ($(b)!0.3!(d)$);
\coordinate (C') at ($(a)!0.73!(c)$);
\coordinate (D') at ($(b)!0.73!(d)$);
\tkzInterLL(A,B)(a,c) \tkzGetPoint{G}
\tkzInterLL(A,B)(b,d) \tkzGetPoint{H}
\tkzInterLL(M,N)(a,c) \tkzGetPoint{K}
\tkzInterLL(M,N)(b,d) \tkzGetPoint{I}
\draw ($(A)+(0.5,0.2)$) node {$\alpha$};
\draw ($(M)+(0.5,0.2)$) node {$\beta$};
\draw (A') node[left] {$A$};
\draw (B') node[right] {$A'$};
\draw (C') node[left] {$B$};
\draw (D') node[right] {$B'$};
\draw (a) node[left] {$a$};
\draw (b) node[right] {$b$};
\tkzDrawSegments(A,B B,C C,D D,A M,N N,P P,Q Q,M a,A' G,C' K,c b,B' H,D' I,d A',B' C',D')
\tkzDrawSegments[dashed](A',G B',H D',I C',K)
\tkzMarkAngles[size=0.7cm,arc=l](B,A,D N,M,Q)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 52,
    Title = "Ba mặt phẳng α, β, γ cắt nhau",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Ba mặt phẳng α, β, γ cắt nhau theo ba đường thẳng, với ba cặp điểm A-A', B-B', C-C'.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_52.png",
    Code = @"\begin{tikzpicture}[line join = round, line cap = round,>=stealth,font=\footnotesize,scale=0.7]
\tkzDefPoints{0/0/A,5/0/B,6.5/1.5/C,3.5/2/d,4/2/d',1/-4.9/e,4.8/-4.9/e'}
\coordinate (D) at ($(A)+(C)-(B)$);
\coordinate (E) at ($(A)+(0,-2.2)$);
\coordinate (F) at ($(E)+(5,0)$);
\coordinate (G) at ($(E)+(6.5,1.5)$);
\coordinate (H) at ($(E)+(G)-(F)$);
\coordinate (M) at ($(A)+(0,-4.4)$);
\coordinate (N) at ($(M)+(5,0)$);
\coordinate (P) at ($(M)+(6.5,1.5)$);
\coordinate (Q) at ($(M)+(P)-(N)$);
\draw ($(A)+(0.5,0.2)$) node {$\alpha$};
\draw ($(E)+(0.5,0.2)$) node {$\beta$};
\draw ($(M)+(0.5,0.2)$) node {$\gamma$};
\tkzInterLL(d,e)(A,B) \tkzGetPoint{m}
\tkzInterLL(d',e')(A,B) \tkzGetPoint{n}
\tkzInterLL(d,e)(E,F) \tkzGetPoint{p}
\tkzInterLL(d',e')(E,F) \tkzGetPoint{q}
\tkzInterLL(d,e)(M,N) \tkzGetPoint{r}
\tkzInterLL(d',e')(M,N) \tkzGetPoint{s}
\coordinate (a) at ($(d)!0.2!(e)$);
\coordinate (b) at ($(d)!0.5!(e)$);
\coordinate (c) at ($(d)!0.8!(e)$);
\coordinate (a') at ($(d')!0.15!(e')$);
\coordinate (b') at ($(d')!0.5!(e')$);
\coordinate (c') at ($(d')!0.85!(e')$);
\tkzDrawSegments(A,B B,C C,D D,A E,F F,G G,H H,E M,N N,P P,Q Q,M d,a m,b p,c r,e d',a' n,b' q,c' s,e' a,a' b,b' c,c')
\draw (a) node[left] {$A$};
\draw (a') node[right] {$A'$};
\draw (b) node[left] {$B$};
\draw (b') node[right] {$B'$};
\draw (c) node[left] {$C$};
\draw (c') node[right] {$C'$};
\tkzDrawSegments[dashed](a,m b,p c,r a',n b',q c',s)
\tkzMarkAngles[size=0.7cm,arc=l](B,A,D F,E,H N,M,Q)
\tkzDrawPoints[fill=black](a,a',b,b',c,c')
\end{tikzpicture}"
},

// ❌ TikZ lỗi (Id=53): Không sinh được PDF

new TikzItem2
{
    Id = 54,
    Title = "Hai mặt phẳng song song P và Q - Hình 2",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình 2: Hai mặt phẳng (P) và (Q) không có điểm chung, do đó (P)∥(Q).",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_54.png",
    Code = @"\begin{tikzpicture}[line join = round, line cap = round,>=stealth,font=\footnotesize,scale=0.7]
\begin{scope}[shift={(8,0)}]
\tkzDefPoints{0/0/A,5/0/B,6.5/2/C}
\coordinate (D) at ($(A)+(C)-(B)$);
\draw ($(A)+(0.5,0.3)$) node {$P$};
\tkzDrawSegments(A,B B,C C,D D,A)
\tkzMarkAngles[size=1cm,arc=l](B,A,D)
\end{scope}
\begin{scope}[shift={(8,-3)}]
\tkzDefPoints{0/0/A,5/0/B,6.5/2/C}
\coordinate (D) at ($(A)+(C)-(B)$);
\draw ($(A)+(0.5,0.3)$) node {$Q$};
\tkzDrawSegments(A,B B,C C,D D,A)
\tkzMarkAngles[size=1cm,arc=l](B,A,D)
\draw (3.25,-1) node {\textbf{Hình 2.}};
\draw (3.25,-2) node {$(P)$, $(Q)$ không có điểm chung: $(P)\parallel (Q)$};
\end{scope}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 55,
    Title = "Hai mặt phẳng P và Q cắt nhau - Hình 1",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình 1: Hai mặt phẳng (P) và (Q) có 1 điểm chung, giao tuyến (P)∩(Q)=a.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_55.png",
    Code = @"\begin{tikzpicture}[line join = round, line cap = round,>=stealth,font=\footnotesize,scale=0.7]
\tkzDefPoints{0/0/A,5/0/B,6.5/1.5/C}
\coordinate (D) at ($(A)+(C)-(B)$);
\coordinate (E) at ($(A)!0.5!(B)$);
\coordinate (F) at ($(D)!0.5!(C)$);
\coordinate (M) at ($(E)+(-0.5,2)$);
\coordinate (N) at ($(F)+(-0.5,2)$);
\coordinate (Q) at ($(M)!2!(E)$);
\coordinate (P) at ($(N)!2!(F)$);
\tkzInterLL(M,Q)(C,D) \tkzGetPoint{G}
\tkzInterLL(N,P)(A,B) \tkzGetPoint{H}
\draw ($(A)+(0.6,0.2)$) node {$P$};
\draw ($(N)+(-0.1,-0.5)$) node {$Q$};
\tkzDrawSegments(A,B B,C C,F G,D N,F H,P D,A M,N P,Q Q,M E,F)
\tkzDrawSegments[dashed](G,F F,H)
\tkzMarkAngles[size=1cm,arc=l](B,A,D)
\tkzMarkAngles[size=1cm,arc=l](M,N,P)
\draw (3.25,-2.5) node {\textbf{Hình 1.}};
\draw (3.25,-3.5) node {$(P)$, $(Q)$ có 1 điểm chung: $(P)\cap (Q)=a$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 56,
    Title = "Hai đường thẳng a và d trên mặt phẳng P",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Mặt phẳng P với hai đường thẳng a và d song song với nhau trên mặt phẳng.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_56.png",
    Code = @"\begin{tikzpicture}[scale=0.7]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/A', 4/0/B', 1/2/D', 1/1/A, 4/1/B, 0/2.5/M}
\coordinate (C') at ($(B')+(D')-(A')$);
\tkzDefPointBy[translation = from A' to B'](M) \tkzGetPoint{N}
\tkzLabelSegment[pos=.3](M,N){ $a$}
\tkzLabelSegment[pos=.3](A,B){ $d$}
%\tkzDrawSegments[dashed](A,A' A',B' A',C')
\tkzDrawPolygon(A',B',C',D')
\tkzDrawSegments(A,B M,N)
%\tkzLabelPoints[right](B)
%\tkzLabelPoints[above](A,B)
\tkzMarkAngles[size=0.8](B',A',D')
\tkzLabelAngle[pos=0.5](D',A',B'){\footnotesize $P$ }
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 57,
    Title = "Hai đường thẳng a và d song song (phiên bản 2)",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Tương tự item 56, mặt phẳng P với hai đường thẳng a và d song song.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_57.png",
    Code = @"\begin{tikzpicture}[scale=0.7]
\tkzDefPoints{0/0/A', 4/0/B', 1/2/D', 1/1/A, 4/1/B, 0/2.5/M}
\coordinate (C') at ($(B')+(D')-(A')$);
\tkzDefPointBy[translation = from A' to B'](M) \tkzGetPoint{N}
\tkzLabelSegment[pos=.3](M,N){ $a$}
\tkzLabelSegment[pos=.3](A,B){ $d$}
%\tkzDrawSegments[dashed](A,A' A',B' A',C')
\tkzDrawPolygon(A',B',C',D')
\tkzDrawSegments(A,B M,N)
%\tkzLabelPoints[right](B)
%\tkzLabelPoints[above](A,B)
\tkzMarkAngles[size=0.8](B',A',D')
\tkzLabelAngle[pos=0.5](D',A',B'){\footnotesize $P$ }
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 58,
    Title = "Hai mặt phẳng với giao tuyến nổi bật",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hai mặt phẳng tạo góc α và β, giao tuyến được đánh dấu màu xanh nổi bật, các điểm a và b.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_58.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.6, line join=round, line cap=round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/A,6/0/B, 4/-2/C,-2/-2/D,1/0/I, 4/0/J, 5/-1/L, 2/-1/M, 2/2/H, -1/2/K, 0.5/1/E, 2.5/1/F, 2/1/a, 3/-1/b}
\tkzDrawSegments(A,I J,B B,C C,D D,A M,K L,H H,K E,F)
\tkzDrawSegments[thick,blue](M,L)
\tkzDrawSegments[dashed](I,J)
\tkzLabelPoints[above](a,b)
\tkzMarkAngles[size=0.8cm](C,D,A)
\tkzLabelAngles[pos=0.5,rotate=30](C,D,A){\scriptsize $\alpha$}
\tkzMarkAngles[size=1cm](M,K,H)
\tkzLabelAngles[pos=0.6,rotate=340](M,K,H){\scriptsize $\beta$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 59,
    Title = "Hình lập phương cắt bởi mặt phẳng",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình lập phương ABCD với mặt phẳng cắt qua điểm E, góc α và β, các đường thẳng d và d'.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_59.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.6, line join=round, line cap=round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/A, 4/0/B, 4/5/C, 0/5/D, 2/4/E, 2/0/I, 2/-1/F, 5/4/M, 5/-1/N, 0/2/d', 5/2/d}
\tkzDrawSegments(A,D A,F F,E E,D I,B B,C C,D M,N)
\tkzDrawSegments[dashed](A,I)
\tkzLabelPoints[right](d)
\tkzLabelPoints[left](d')
\tkzMarkAngles[size=0.8cm](E,F,A)
\tkzLabelAngles[pos=0.5,rotate=30](E,F,A){\scriptsize $\alpha$}
\tkzMarkAngles[size=0.8cm](C,B,A)
\tkzLabelAngles[pos=0.5,rotate=30](C,B,A){\scriptsize $\beta$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 60,
    Title = "Hình bình hành với các đường thẳng a, b, b', M",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành ABCD với góc α, các đường thẳng a, b, b' và điểm M, Q trong không gian.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_60.png",
    Code = @"\begin{tikzpicture}[>=stealth,scale=0.5, line join=round, line cap=round]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/A, 6/0/B, 5/-3/C, -1/-3/D, 1/-1/E, 5/-1/b', 4/-2.5/a, 2/-1/M, 1/-0.5/Q, 1/1/L, 5/1/b}
\tkzDrawSegments(A,B B,C C,D D,A E,b' a,Q L,b)
\tkzLabelPoints[above](M,b',b,a)
\tkzMarkAngles[size=0.8cm](C,D,A)
\tkzLabelAngles[pos=0.5,rotate=30](C,D,A){\scriptsize$\alpha$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 61,
    Title = "Đường thẳng a với điểm A và B trên mặt phẳng P",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Mặt phẳng P với đường thẳng a đi qua hai điểm A và B nằm trên mặt phẳng.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_61.png",
    Code = @"\begin{tikzpicture}[scale=.8]
\tkzDefPoints{0/0/A', 4/0/B', 1/2/D', 1/1/A, 4/1/B}
\coordinate (C') at ($(B')+(D')-(A')$);
\tkzLabelSegment[pos=.6](A,B){$a$}
%\tkzDrawSegments[dashed](A,A' A',B' A',C')
\tkzDrawPolygon(A',B',C',D')
\tkzDrawSegments(A,B)
%\tkzLabelPoints[right](B)
\tkzLabelPoints[above](A,B)
\tkzMarkAngles[size=1](B',A',D')
\tkzLabelAngle[pos=0.6](D',A',B'){\footnotesize $P$ }
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 62,
    Title = "Đường thẳng a cắt mặt phẳng P tại A",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Đường thẳng a cắt mặt phẳng P tại điểm A, với giao tuyến I và J trên mặt phẳng.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_62.png",
    Code = @"\begin{tikzpicture}[scale=.8]
\tkzDefPoints{0/0/A', 4/0/B', 1/2/D', 2/1/A, 0/2.5/B}
\coordinate (C') at ($(B')+(D')-(A')$);
\tkzLabelSegment[pos=.3](A,B){ $a$}
\tkzInterLL(A,B)(A',B')\tkzGetPoint{I}
\tkzInterLL(A,B)(C',B')\tkzGetPoint{J}
\tkzDrawPolygon(A',B',C',D')
\tkzDrawSegments(A,B I,J)
\tkzDrawSegments[dashed](A,I)
%\tkzLabelPoints[right](B)
\tkzLabelPoints[above right](A)
\tkzMarkAngles[size=1](B',A',D')
\tkzLabelAngle[pos=0.6](D',A',B'){\footnotesize $P$ }
\tkzDrawPoints(A)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 63,
    Title = "Đường thẳng a song song với mặt phẳng P (đơn giản)",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Mặt phẳng P với đường thẳng a song song, biểu diễn đơn giản.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_63.png",
    Code = @"\begin{tikzpicture}[scale=.8]
\tkzDefPoints{0/0/A', 4/0/B', 1/2/D', 0/2.5/M}
\coordinate (C') at ($(B')+(D')-(A')$);
\tkzDefPointBy[translation = from A' to B'](M) \tkzGetPoint{N}
\tkzLabelSegment[pos=.3](M,N){ $a$}
%\tkzDrawSegments[dashed](A,A' A',B' A',C')
\tkzDrawPolygon(A',B',C',D')
\tkzDrawSegments(M,N)
%\tkzLabelPoints[right](B)
%\tkzLabelPoints[above](z,y)
\tkzMarkAngles[size=1](B',A',D')
\tkzLabelAngle[pos=0.6](D',A',B'){\footnotesize $P$ }
%\tkzDrawPoints(M,N,A)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 64,
    Title = "Ba vị trí tương đối của hai mặt phẳng",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Ba trường hợp: hai mặt phẳng song song, cắt nhau, hoặc trùng nhau, với các đường thẳng d, d', d'' và góc α, β.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_64.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,x=1.0cm,y=1.0cm, font=\scriptsize]
\begin{scope}[>=stealth,scale=0.5]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/A,0/5/B, 3/4/C,3/-1/D, -3/3/E, -3/-2/F, -2/3/I, -2/0/J}
\coordinate (d) at ($(A)!0.5!(B)$);
\coordinate (d') at ($(I)!0.5!(J)$);
\coordinate (d'') at ($(A)!0.2!(B)$);
\tkzDrawSegments(F,A E,F E,B B,A B,C C,D D,A I,J)
\tkzMarkAngles[size=0.8cm](F,E,B)
\tkzLabelAngles[pos=0.5,rotate=30](B,E,F){$\alpha$}
\tkzMarkAngles[size=0.8cm](B,C,D)
\tkzLabelAngles[pos=0.5,rotate=320](D,C,B){$\beta$}
%\tkzMarkAngles[size=0.5cm]
\tkzLabelPoints[right](d'')
\tkzLabelPoints[left](d,d')
\end{scope}
\begin{scope}[xshift=4.5cm,>=stealth,scale=0.5]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/A,0/5/B, 3/4/C,3/-1/D, -3/3/E, -3/-2/F, -2/3/I, -2/0/J, 2/4/M, 2/0/N}
\coordinate (d) at ($(A)!0.5!(B)$);
\coordinate (d') at ($(I)!0.5!(J)$);
\coordinate (d'') at ($(M)!0.5!(N)$);
\tkzDrawSegments(F,A E,F E,B B,A B,C C,D D,A I,J M,N)
\tkzMarkAngles[size=0.8cm](F,E,B)
\tkzLabelAngles[pos=0.5,rotate=30](B,E,F){$\alpha$}
\tkzMarkAngles[size=0.8cm](B,C,D)
\tkzLabelAngles[pos=0.5,rotate=320](D,C,B){$\beta$}
%\tkzMarkAngles[size=0.5cm]
\tkzLabelPoints[right](d'')
\tkzLabelPoints[left](d,d')
\end{scope} 
\begin{scope}[xshift=8cm,>=stealth,scale=0.5]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/A,0/5/B, 3/4/C,3/-1/D, -3/3/E, -3/-2/F, -2/3/I, -2/0/J, 2/4/M, 2/0/N}
\coordinate (d) at ($(A)!0.5!(B)$);
\coordinate (d') at ($(A)!0.2!(B)$);
\coordinate (d'') at ($(M)!0.5!(N)$);
\tkzDrawSegments(F,A E,F E,B B,A B,C C,D D,A M,N)
\tkzMarkAngles[size=0.8cm](F,E,B)
\tkzLabelAngles[pos=0.5,rotate=30](B,E,F){$\alpha$}
\tkzMarkAngles[size=0.8cm](B,C,D)
\tkzLabelAngles[pos=0.5,rotate=320](D,C,B){$\beta$}
%\tkzMarkAngles[size=0.5cm]
\tkzLabelPoints[right](d'', d')
\tkzLabelPoints[left](d)
\end{scope} 
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 65,
    Title = "Hai đường thẳng song song a và b",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành α với hai đường thẳng song song a và b trong không gian.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_65.png",
    Code = @"\begin{tikzpicture}[scale=0.6,font=\scriptsize]
\tkzDefPoints{0/0/A, 5/0/B, 6/3/C}
\coordinate (D) at ($(A)+(C)-(B)$);
\tkzDrawPolygon(A,B,C,D)
\tkzMarkAngle[size=.85](B,A,D)
\draw (A) node[above right]{$\alpha$};
\tkzDefPoints{0.8/1.5/G, 5/2.5/H, 1/0.5/I}
\coordinate (K) at ($(H)+(I)-(G)$);
\draw (G)--(H) (I)--(K);
\draw ($(G)!0.8!(H)$) node[above]{$a$};
\draw ($(I)!0.8!(K)$) node[above]{$b$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 66,
    Title = "Hai đường thẳng trùng nhau a và b",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành α với hai đường thẳng a và b trùng nhau.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_66.png",
    Code = @"\begin{tikzpicture}[scale=0.6,font=\scriptsize]
\tkzDefPoints{0/0/A, 5/0/B, 6/3/C}
\coordinate (D) at ($(A)+(C)-(B)$);
\tkzDrawPolygon(A,B,C,D)
\tkzMarkAngle[size=.85](B,A,D)
\draw (A) node[above right]{$\alpha$};
\tkzDefPoints{0.5/0.8/G, 5/2.5/H}
\draw (G)--(H);
\draw ($(G)!0.2!(H)$) node[above]{$a$};
\draw ($(G)!0.2!(H)$) node[below]{$b$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 67,
    Title = "Hai đường thẳng cắt nhau a và b tại I",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành α với hai đường thẳng a và b cắt nhau tại điểm I.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_67.png",
    Code = @"\begin{tikzpicture}[scale=0.6,font=\scriptsize]
\tkzDefPoints{0/0/A, 5/0/B, 6/3/C}
\coordinate (D) at ($(A)+(C)-(B)$);
\tkzDrawPolygon(A,B,C,D)
\tkzMarkAngle[size=.85](B,A,D)
\draw (A) node[above right]{$\alpha$};
\tkzDefPoints{0.8/0.5/G, 4.5/1.5/H, 2/3.5/E, 2.5/-0.5/F}
\tkzInterLL(A,B)(E,F) \tkzGetPoint{K}
\coordinate (I) at ($(E)!0.4!(F)$);
\draw (G)--(H) (E)--(I) (K)--(F);
\draw[dashed] (I)--(K);
\draw ($(E)!0.1!(F)$) node[right]{$a$};
\draw ($(G)!0.9!(H)$) node[above]{$b$};
\draw [fill=black] (I) circle(1pt);
\tkzLabelPoints[left](I)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 68,
    Title = "Ba mặt phẳng đôi một cắt nhau",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hai trường hợp: ba mặt phẳng α, β, γ cắt nhau theo ba giao tuyến a, b, c đồng quy hoặc song song.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_68.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,x=1.0cm,y=1.0cm, font=\scriptsize]
\begin{scope}[>=stealth,scale=0.5]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/A,0/5/B, 3/4/C,3/-1/D, -3/3/E, -3/-2/F, 0/4/I}
\coordinate (J) at ($(A)!0.77!(F)$);
\coordinate (M) at ($(A)!0.5!(D)$);
\coordinate (c) at ($(I)!0.5!(B)$);
\coordinate (a) at ($(I)!0.5!(J)$);
\coordinate (b) at ($(I)!0.5!(M)$);
\tkzDrawSegments[dashed](A,M A,J A,I)
\tkzDrawSegments(F,J E,F E,B B,I B,C C,D D,M M,I M,J I,J)
\tkzMarkAngles[size=0.8cm](F,E,B)
\tkzLabelAngles[pos=0.5,rotate=30](B,E,F){$\alpha$}
\tkzMarkAngles[size=0.8cm](B,C,D)
\tkzLabelAngles[pos=0.5,rotate=320](D,C,B){$\beta$}
\tkzMarkAngles[size=0.8cm](M,J,I)
\tkzLabelAngles[pos=0.5,rotate=30](M,J,I){$\gamma$}
%\tkzMarkAngles[size=0.5cm]
\tkzLabelPoints[right](b,c)
\tkzLabelPoints[left](a)
\end{scope}
\begin{scope}[xshift=5cm,>=stealth,scale=0.5]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/A,0/5/B, 3/4/C,3/-1/D, -3/3/E, -3/-2/F, 0/4/I}
\coordinate (J) at ($(A)!0.6!(F)$);
\coordinate (P) at ($(B)!0.6!(E)$);
\coordinate (Q) at ($(B)!0.5!(C)$);
\tkzInterLL(A,B)(Q,P) \tkzGetPoint{I}
\coordinate (M) at ($(A)!0.5!(D)$);
\coordinate (c) at ($(I)!0.5!(B)$);
\coordinate (a) at ($(I)!0.5!(J)$);
\coordinate (b) at ($(I)!0.5!(M)$);
\tkzDrawSegments[dashed](A,M A,J A,I)
\tkzDrawSegments(F,J E,F E,B B,I B,C C,D D,M M,Q M,J J,P P,Q)
\tkzMarkAngles[size=0.8cm](F,E,B)
\tkzLabelAngles[pos=0.5,rotate=30](B,E,F){$\alpha$}
\tkzMarkAngles[size=0.8cm](B,C,D)
\tkzLabelAngles[pos=0.5,rotate=320](D,C,B){$\beta$}
\tkzMarkAngles[size=0.8cm](M,J,I)
\tkzLabelAngles[pos=0.5,rotate=30](M,J,P){$\gamma$}
%\tkzMarkAngles[size=0.5cm]
\tkzLabelPoints[right](b,c)
\tkzLabelPoints[left](a)
\end{scope} 
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 69,
    Title = "Hai đường thẳng a và b cắt nhau tại M",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành α với hai đường thẳng a và b cắt nhau tại điểm M.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_69.png",
    Code = @"\begin{tikzpicture}[scale=0.6,font=\scriptsize]
\tkzDefPoints{0/0/A, 5/0/B, 6/3/C}
\coordinate (D) at ($(A)+(C)-(B)$);
\tkzDrawPolygon(A,B,C,D)
\tkzMarkAngle[size=.85](B,A,D)
\draw (A) node[above right]{$\alpha$};
\tkzDefPoints{1/2/E, 4.5/0.5/F, 0.8/1.5/G, 5/2.5/H}
\draw (E)--(F) (G)--(H);
\tkzInterLL(E,F)(G,H) \tkzGetPoint{M}
\tkzDrawPoints[size=5,fill=black](M)
\tkzLabelPoints[above](M)
\draw (F) node[above]{$a$};
\draw (H) node[below]{$b$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 70,
    Title = "Hai mặt phẳng cắt nhau theo giao tuyến",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hai hình thang với góc α và β, ba điểm A, B, C trên giao tuyến, hai đường thẳng a và b trong không gian.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_70.png",
    Code = @"\begin{tikzpicture}[scale=0.65, font=\footnotesize,line join=round, line cap=round,>=stealth]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/M,7/0/N,10/-2/P,3/-2/Q,6/2/X,3/5/Y, 2.5/3/E, 5.5/-1/F}
\tkzInterLL(M,N)(Q,X)\tkzGetPoint{T}
\coordinate (A) at ($(M)!0.15!(Q)$);
\coordinate (B) at ($(M)!0.45!(Q)$);
\coordinate (C) at ($(M)!0.84!(Q)$);
\tkzInterLL(A,F)(X,Q)\tkzGetPoint{I}
\tkzDrawPoints[size=5,fill=black](A,B,C)
\tkzLabelPoints[below](A,B,C)
\tkzLabelSegment(I,F){$b$}
\tkzLabelSegment(A,E){$a$}
\tkzLabelAngles[pos=0.6,rotate=30](M,Y,X){$\alpha$}
\tkzLabelAngles[pos=0.9,rotate=10](N,P,Q){$\beta$}
\tkzDrawPolygon(M,Q,X,Y)
\tkzDrawSegments(M,Q Q,P N,P T,N A,E I,F)
\tkzDrawSegments[dashed](M,T A,I)
\tkzMarkAngles[size=1cm,arc=l](M,Y,X)
\tkzMarkAngles[size=1.35cm,arc=l](N,P,Q)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 71,
    Title = "Hai mặt phẳng P và Q với đường thẳng a, d",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hai mặt phẳng P và Q với đường thẳng a, d song song với d, điểm M là trung điểm.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_71.png",
    Code = @"\begin{tikzpicture}[line cap=round, line join=round,font=\footnotesize,>=stealth, scale=0.9]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/a, 4.5/0/b, 4/2/c, 4.2/2.3/b'}
\tkzDefBarycentricPoint(a=1,c=1,b=-1)\tkzGetPoint{d}
\tkzDefBarycentricPoint(a=0.75,b=0.25)\tkzGetPoint{a'}
\tkzDefBarycentricPoint(d=0.75,c=0.25)\tkzGetPoint{d'}
\tkzDefBarycentricPoint(d'=1,b'=1,a'=-1)\tkzGetPoint{c'}
\tkzInterLL(a',b')(c,d)\tkzGetPoint{x}
\tkzDefMidPoint(a',d')\tkzGetPoint{M}
\tkzDefLine[parallel=through M](a',b')\tkzGetPoint{y}
\tkzDrawPolygon(a',b',c',d')
\tkzDrawSegments(a,b b,c d,a c,x d,d')
\tkzDrawSegments[dashed](x,d')
\tkzDrawSegments[add=0 and -0.3](M,y)
\tkzLabelSegments[above, pos=0.7](M,y){$d$}
\tkzDrawSegments[add=0.2 and -1, dashed](M,y)
\tkzMarkAngle[size=0.5](c',b',a')
\tkzLabelAngle[pos=-0.25](a',b',c'){$Q$}
\tkzMarkAngle[size=0.5](b,a,d)
\tkzLabelAngle[pos=0.25](b,a,d){$P$}
\tkzLabelSegments[pos=0.8, right](a',d'){$a$}
\tkzDrawPoints[fill=black](M)
\tkzLabelPoints[below right](M)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 72,
    Title = "Hình chóp lục giác S.A₁A₂A₃A₄A₅A₆",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình chóp lục giác đều S.A₁A₂A₃A₄A₅A₆ với đỉnh S và đáy lục giác, mặt phẳng P cắt hình chóp.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_72.png",
    Code = @"\begin{tikzpicture}[scale=1.3, line join=round, line cap=round]
\tkzDefPoints{0/0/A1,0.3/-1/A2,1/-1.6/A3,1.7/-1.5/A4,2.2/-1/A5,2.5/0.3/A6,1/2/S,-1.5/-2/P,-0.7/0.3/Q,3/-2/R}
\tkzDrawPolygon(S,A1,A2,A3,A4,A5,A6)
\tkzDrawSegments(S,A2 S,A3 S,A4 S,A5 P,Q P,R)
\tkzDrawSegments[dashed](A1,A6)
\tkzDrawPoints[fill=black](S,A1,A2,A3,A4,A5,A6)
\tkzLabelPoints[above](S)
\tkzLabelPoints[above right](P)
\tkzLabelPoint[left](A1){$A_1$}
\tkzLabelPoint[left](A2){$A_2$}
\tkzLabelPoint[below](A3){$A_3$}
\tkzLabelPoint[below](A4){$A_4$}
\tkzLabelPoint[right](A5){$A_5$}
\tkzLabelPoint[right](A6){$A_6$}
\tkzMarkAngle[size=0.6cm,opacity=.4,draw=black,mksize=2](R,P,Q)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 73,
    Title = "Hình thang với các điểm vuông góc",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình thang MNPQ với góc α, điểm A, các điểm H, K vuông góc, B và C trên đoạn EF.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_73.png",
    Code = @"\begin{tikzpicture}[scale=0.8, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/M,1/2/N,6/2/P,2/4/A,1.5/0.4/E,5.4/1.5/F,2/1.6/H}
\tkzDefPointBy[translation=from N to P](M) \tkzGetPoint{Q}
\tkzDefBarycentricPoint(E=4,F=1) \tkzGetPoint{B}
\tkzDefBarycentricPoint(E=1,F=4) \tkzGetPoint{C}
\tkzDefBarycentricPoint(E=4,F=5)\tkzGetPoint{K}
\tkzInterLL(N,P)(A,H) \tkzGetPoint{X}
\tkzInterLL(N,P)(A,K) \tkzGetPoint{Y}
\tkzDrawSegments(E,F A,K A,H H,K M,N N,X Y,P P,Q M,Q)
\tkzDrawSegments[dashed](X,Y)
\tkzDrawPoints[fill=black,size=6](A,K,H,B,C)
\tkzMarkRightAngle(A,H,K) 
\tkzMarkRightAngle(A,K,C) 
\tkzMarkAngle(Q,M,N)
\tkzLabelAngles[pos=0.6](Q,M,N){$\alpha$}
\tkzLabelPoints[below](B,K,C)
\tkzLabelPoints[below left](H)
\tkzLabelPoints[above](A)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 74,
    Title = "Mặt phẳng P với đường thẳng Δ, Δ', d",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Mặt phẳng (P) với ba đường thẳng (Δ), (Δ'), (d), điểm H, M, A, K, góc α, các quan hệ vuông góc.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_74.png",
    Code = @"\begin{tikzpicture}
\tkzDefPoint(0,0){H}
\tkzDefShiftPoint[H](90:4){M}
\tkzDefShiftPoint[H](7:5.2){p}
\tkzDefShiftPoint[p](180:7.5){p1}
\tkzDefShiftPoint[p](-110:3){p2}
\tkzDefShiftPoint[p2](180:7.5){p3}
\tkzDefShiftPoint[H](-10:3){A}
\tkzDefShiftPoint[A](-150:1.2){a}
\tkzDefShiftPoint[H](-165:2){k}
\tkzInterLL(p,p1)(M,A) \tkzGetPoint{i1}
\tkzInterLL(p,p1)(M,k) \tkzGetPoint{i2}
\tkzDrawPoints[fill = black](H,M,A,k)
\tkzDrawLine[add = 1.2 and 0.2](A,a)
\tkzDrawLine[add = .2 and 0.1](A,k)
\tkzDrawLine[add = .2 and 0](M,A)
\tkzDrawSegments(k,M i1,p i2,p1 p,p2 p2,p3)
\tkzDrawSegments[dashed](H,M H,k H,A i1,i2)
\tkzMarkRightAngles[size=0.25](M,H,k M,H,A M,A,a H,k,A)
\node at (H)[below ]{$ H $};
\node at (M)[above right]{$ M $};
\node at (A)[below]{$ A $};
\node at (k)[below]{$ K $};
\node at ($ (M)+ (-1,0.5) $)[above]{$ (\Delta) $};
\node at ($ (A)+ (1.2,-0.05) $)[below]{$ (\Delta') $};
\node at ($ (a)+ (0.1,-0.05) $)[below]{$ (d) $};
\tkzMarkAngles[size=0.6](H,k,M) \tkzLabelAngles[pos=0.4](H,k,M){$ \alpha $}
\tkzMarkAngles[size=0.8](p,p2,p3) \tkzLabelAngles[pos=0.4](p,p2,p3){$ (P) $}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 75,
    Title = "Ký hiệu mặt phẳng (P) hoặc mp(P)",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành ABCD biểu diễn mặt phẳng P với ký hiệu (P) hoặc mp(P).",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_75.png",
    Code = @"\begin{tikzpicture}[scale=0.7, line join=round, line cap=round]
\tkzDefPoints{0/0/A,4/0/B,5.5/2/C,1.5/2/D}
\tkzDrawPolygon(A,B,C,D)
\tkzMarkAngles[size=0.7cm,arc=l](B,A,D)
\tkzLabelAngles[pos=0.4,rotate=30](B,A,D){\footnotesize$P$}
\node[right] at (0,-1) {Kí hiệu $(P)$ hoặc mp$(P)$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 76,
    Title = "Ký hiệu mặt phẳng (α) hoặc mp(α)",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Góc tạo bởi hai đoạn thẳng biểu diễn mặt phẳng α với ký hiệu (α) hoặc mp(α).",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_76.png",
    Code = @"\begin{tikzpicture}[scale=0.7, line join=round, line cap=round]
\tkzDefPoints{0/0/A,4/0/B,1.5/2/D}
\tkzDrawSegments(A,B A,D)
\tkzMarkAngles[size=0.7cm,arc=l](B,A,D)
\tkzLabelAngles[pos=0.4,rotate=30](B,A,D){\footnotesize$\alpha$}
\node[right] at (0,-1) {Kí hiệu $(\alpha)$ hoặc mp$(\alpha)$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 77,
    Title = "Hình tròn cắt bởi mặt phẳng tạo elip",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Đường tròn tâm I bị cắt bởi mặt phẳng P, tạo elip, với các điểm A, B, M, H, Y.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_77.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round, scale=0.6]
\clip (-6.5,-5.75) rectangle (4.5,3.75);
\def \R{3}
\def \a{15}% 5<\a<=35 Nếu def lại điểm H xa hơn có thể tăng góc \a
\def \b{-15}%-25 <\be< 0 Góc xoay của Elip
\pgfmathsetmacro\H{\R*cos(\a)}
\pgfmathsetmacro\L{sqrt((\R^2*(cos(\a))^2*(sin(\b))^2)/(1-(cos(\a))^2*(cos(\b))^2)))}
\coordinate (I) at (0,0);
\draw (I) circle (\R);
\coordinate (A) at (0,\H);
\coordinate (B) at (0,-\H);
\coordinate (C) at ($(I) + (2*\b-90:\H)$);
\coordinate (G) at ($(I) + (\b-90:\R)$);
\coordinate (M) at ($(I) + (\b+5:\R)$);
\coordinate (F) at ($2*(I)-(G)$);
\coordinate (U) at ($2*(C)$);
\coordinate (H) at ($3/2*(B)$);
\coordinate (D) at ($ 5/4*(B) $);
\tkzDefLine[perpendicular=through D](I,H)\tkzGetPoint{a}
\tkzInterLL(I,C)(D,a) \tkzGetPoint{E}
\coordinate (b) at ($ 2*(D)-(a) $);
\coordinate (d) at ($(a) + (-135:\R)$);
\coordinate (c) at ($(b)+(d)-(a)$);
\draw[dashed,rotate=\b] (G) arc (-90:90:{\L} and {\R});
\draw[rotate=\b] (G) arc (270:90:{\L} and {\R});
\tkzDrawPoints[fill = black,size = 2 pt](I,A,B,M,H)
\tkzDefPointBy[projection= onto A--B](M) \tkzGetPoint{Q}
\coordinate (Y) at ($(M)!0.6!(H)$);
\draw[dashed] (A)--(0,-\R) (M)--(H) (M)--(Y) (M)--(I);
\draw (0,-\R) -- (H)(D)--(a)--(d)--(c)--(b) -- (E) (D) -- (E) (Y)--(H);
%\tkzMarkRightAngle(I,H,U)
\tkzMarkAngles(d,c,b)
\tkzLabelAngle[pos=0.7](d,c,b){$P$}
\tkzLabelPoints[right](H,M)
\tkzLabelPoints[left](I)
\tkzLabelPoints[above left](B)
\tkzLabelPoints[above](A)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 78,
    Title = "Hình thang với các điểm vuông góc A, K, H",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình thang SBCD với mặt phẳng P, các điểm A, K, H thỏa mãn quan hệ vuông góc, đường thẳng EF.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_78.png",
    Code = @"\begin{tikzpicture}[scale=0.7, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/D,7/0/C,3/3/S,3/.5/E,8/2.5/F}
\coordinate (B) at ($(S)+(C)-(D)$);
\coordinate (K) at ($(S)!0.3!(C)$);
\coordinate (H) at ($(F)!0.4!(E)$);
\coordinate (A) at ($(K)+(0,5)$);
\tkzDrawPolygon(S,B,C,D)
\tkzDrawSegments(A,K E,F K,A K,H A,H)
\tkzLabelPoints[left](A,K)
\tkzLabelPoints[right](H)
\tkzMarkRightAngles[size=0.4,fill=gray!50](K,H,E)
\tkzMarkRightAngles[size=0.4,fill=gray!50](A,K,H)
\tkzMarkRightAngles[size=0.4,fill=gray!50](A,H,F)
\tkzMarkAngles[size=1.15cm,arc=l](C,D,S)
\tkzLabelAngles[pos=.75,rotate=10](C,D,S){$P$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 79,
    Title = "Hình bình hành với các quan hệ vuông góc",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành với mặt phẳng P, các điểm K, H, E, M, N thỏa mãn quan hệ vuông góc KH⊥E và KE⊥M.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_79.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round]
\def\a{5}
\def\h{0.6*\a}% chiều cao
\pgfmathsetmacro\b{0.5*\a}
\coordinate (o) at (0,0);
\tkzDefShiftPoint[o](0:\a){a}
\tkzDefShiftPoint[o](70:\b){b}
\coordinate(c) at ($(a)+(b)-(o)$);
\tkzDefShiftPoint[o](40:\b){H}
\tkzDefShiftPoint[H](90:\h){K}
\tkzDefShiftPoint[H](-10:\b){M}
\tkzDefShiftPoint[H](-130:0.6*\b){N}
\coordinate (E) at ($(M)!0.3!(N)$);
\tkzInterLL(b,c)(H,K)\tkzGetPoint{hk}
\tkzInterLL(b,c)(E,K)\tkzGetPoint{ek}
\tkzDrawLines[add = 0.1 and 0.1](M,N)
\tkzDrawPoints[fill=black](K,H,M,N,E)
\tkzDrawSegments(o,a a,c c,ek hk,b b,o K,H K,E H,E)
\tkzDrawSegments[dashed](ek,hk)
\tkzLabelPoints[above](K)
\tkzLabelPoints[left](H)
\tkzLabelPoints[below](M,N,E)
\tkzMarkRightAngles[size=0.2](K,H,E K,E,M)
\tkzMarkAngles[size=0.5cm,arc=l](c,a,o)
\tkzLabelAngles[pos=0.3](o,a,c){$P$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 80,
    Title = "Hình bình hành P với đường thẳng d và các điểm vuông góc",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành P với đường thẳng d, các điểm I, K, H thỏa mãn IK⊥A và IH⊥K.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_80.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,font=\footnotesize,>=stealth,scale=0.75]
\fill (0,0) coordinate (x)
(4,0) coordinate (y)
(60:2) coordinate (t)
($(y)+(t)$) coordinate (z)
(40:2) coordinate (A)
(5:4) coordinate (B)
($(A)!0.3!(B)$) coordinate [label=below:$K$] (K) circle(1pt)
($(A)+(2,0.25)$) coordinate [label=below:$H$] (H) circle(1pt)
($(H)+(0,3)$) coordinate [label=right:$I$] (I) circle(1pt);
\draw (x)--(y)--(z)--(t)--(x) (H)--(I)--(K)--(H);
\draw (A)--(B) node[above,pos=1] {$d$};
\tkzMarkRightAngles[size=0.2](I,K,A I,H,K) 
\tkzMarkAngle[size=.8](y,x,t)
\draw (x) node[shift={(30:2ex)}]{$P$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 81,
    Title = "Tam giác MNP vuông tại N với tọa độ",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Tam giác MNP vuông tại N với tọa độ M(2;3;-1), N(-1;1;1), P(1;m-1;2).",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_81.png",
    Code = @"\begin{tikzpicture}[scale=0.9, font=\normalsize, line join=round, line cap=round, >=stealth]
\path
(4,0) coordinate (M)node[below]{$ M(2;3;-1) $}
(0,0) coordinate (N)node[below]{$ N(-1;1;1) $}
(0,2) coordinate (P) node[above]{$ P(1;m-1;2) $}
;
\draw (M)--(N)--(P)--cycle
pic [draw=red,fill=yellow!30,angle radius=4mm] {right angle = M--N--P};
\foreach \p/\r in {M,N,P}
\draw[fill=white] (\p) circle (1.5pt) ;
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 82,
    Title = "Tam giác AOB với đường cao AH",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Tam giác AOB vuông tại H với tọa độ A(1;2;-1), O(0;0;0), B(0;-2;3), H là chân đường cao từ A.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_82.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize, line join=round, line cap=round, >=stealth]
\path
(1,2.5) coordinate (A) node[above]{$ A(1;2;-1)$}
(0,0) coordinate (O)node[below]{$ O(0;0;0) $}
(4,0) coordinate (B) node[below]{$ B(0;-2;3) $}
($(O)!(A)!(B)$) coordinate (H) node[below]{$ H $}
;
\draw (A)--(O)--(B)--cycle
pic [draw=red,fill=yellow!30,angle radius=4mm] {right angle = A--H--B};;
\draw[red,line width=1pt] (A)--(H);
\foreach \p/\r in {A,O,B,H}
\draw[fill=white] (\p) circle (1.5pt) ;
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 83,
    Title = "Hình thang với điểm M, M', I",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình thang ABCD với điểm M(0;-1;0), I(0;-1;-1), M' là hình chiếu của M lên mặt đáy.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_83.png",
    Code = @"\begin{tikzpicture}[scale=0.9, font=\footnotesize, line join=round, line cap=round, >=stealth]
\path
(2,2) coordinate (A)
(0,0) coordinate (B)
(4.5,0) coordinate (C)
(6.5,2) coordinate (D)
(4,1) coordinate (M)node[below]{$ M(0;-1;0) $}
(4,4) coordinate (I) node[above]{$ I(0;-1;-1) $}
(2,0.7) coordinate (M')node[below]{$ M' $}
;
\begin{scope}
\clip (C)--(B)--(A);
\draw[fill=cyan!20] (B) circle(1.2cm)
node[shift={(15:0.7cm)}]{$Oxy$};
14 \end{scope}
\draw (A)--(B)--(C)--(D)--cycle
(M')--(M)--(I)
pic [draw=red,fill=yellow!30,angle radius=4mm] {right angle = M'--M--I}
;
\draw[dashed](I)--(M');
\foreach \p/\r in {M',M,I}
\draw[fill=white] (\p) circle (1.5pt) ;
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 84,
    Title = "Hình thang với đường thẳng d",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình thang với các điểm H, A, B và đường thẳng d, quan hệ vuông góc AH⊥B.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_84.png",
    Code = @"\begin{tikzpicture}
\tkzInit[ymin=-0.5,ymax=7,xmin=-2,xmax=4.1]
\tkzClip
\tkzDefPoints{0/0/B,0/6/H,2/6/A,1.5/4.5/C,0/4.5/D,0.75/2.25/E,0/2.25/F,-1/6/h,4/6/a,-1.5/2.25/X,-0.75/4.5/Y,4/4.5/P,3.25/2.25/T}
\tkzDefMidPoint(A,B)\tkzGetPoint{M}
\tkzDefMidPoint(B,H)\tkzGetPoint{N}
\tkzDrawSegments(h,a A,M H,N B,E B,F X,Y Y,D C,P P,T T,X)
\tkzMarkAngle[size=0.75](C,P,T)
\tkzDrawSegments[dashed](C,D M,E N,F) 
\tkzLabelSegment[pos=0.9](h,a){$d$}
\tkzLabelPoints[above](H,A)
\tkzLabelPoints[below](B)
\tkzLabelPoints[below left](P)
\tkzMarkRightAngle(A,H,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 85,
    Title = "Hình thang P với đoạn AM vuông góc MB",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình thang P với điểm A, M, B thỏa AM⊥MB.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_85.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize,line join=round, line cap=round, >=stealth]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/a,-0.8/-1.5/b,5/0/d}
\coordinate (c) at ($(d)-(a)+(b)$);
\coordinate (B) at (3.5,-0.6);
\coordinate (M) at (1.2,-1);
\coordinate (A) at ($(M)+(0,1.8)$);
\tkzDrawLines[add = 0 and 0.4](B,A)
\tkzDrawLines[add = 0.4 and 0.6](B,M)
\tkzDrawSegment(A,M)
\foreach \i in {M,B} \fill (\i)node[below]{$\i$} circle(1.5pt);
\fill (A)node[above]{$A$} circle(1.5pt);
\tkzDrawPolygon[black](a,b,c,d)
\tkzMarkRightAngle[size=0.2](A,M,B)
\tkzLabelAngles[pos=0.35,rotate=10](a,b,c){$P$}
\tkzMarkAngles[size=0.55cm,arc=l](c,b,a)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 86,
    Title = "Hình thang P với AM⊥MB (phiên bản 2)",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Tương tự item 85, hình thang P với điểm A, M, B thỏa AM⊥MB.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_86.png",
    Code = @"\begin{tikzpicture}[scale=1, font=\footnotesize,line join=round, line cap=round, >=stealth]
\tikzset{label style/.style={font=\footnotesize}}
\tkzDefPoints{0/0/a,-0.8/-1.5/b,5/0/d}
\coordinate (c) at ($(d)-(a)+(b)$);
\coordinate (B) at (3.5,-0.6);
\coordinate (M) at (1.2,-1);
\coordinate (A) at ($(M)+(0,1.8)$);
\tkzDrawLines[add = 0 and 0.4](B,A)
\tkzDrawLines[add = 0.4 and 0.6](B,M)
\tkzDrawSegment(A,M)
\foreach \i in {M,B} \fill (\i)node[below]{$\i$} circle(1.5pt);
\fill (A)node[above]{$A$} circle(1.5pt);
\tkzDrawPolygon[black](a,b,c,d)
\tkzMarkRightAngle[size=0.2](A,M,B)
\tkzLabelAngles[pos=0.35,rotate=10](a,b,c){$P$}
\tkzMarkAngles[size=0.55cm,arc=l](c,b,a)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 87,
    Title = "Hệ tọa độ Oyz với mặt phẳng P",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hệ tọa độ Oyz với mặt phẳng P, các điểm A, A', A'', I, H, C, B, M, các quan hệ và giao tuyến.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_87.png",
    Code = @"\begin{tikzpicture}[scale=0.8,>=stealth, font=\footnotesize, line join=round, line cap=round]
\clip (-5,-2) rectangle (6,5);
%%%%%%%%%%%%%%%
\tkzDefPoints{-1/0/a,4/0/b,0/2/d,5/2/c,-2/3/e,-1/5/f,2/3/A,2/1/H,-1/3.5/I,0/0/O}
\coordinate (A') at ($(A)!2!(H)$);
\coordinate (A'') at ($(A)!2!(I)$);
\tkzInterLL(A,I)(e,f)\tkzGetPoint{T}
\tkzInterLL(A,H)(a,b)\tkzGetPoint{K}
\tkzInterLL(A',A'')(O,d)\tkzGetPoint{B}
\tkzInterLL(A',A'')(a,b)\tkzGetPoint{M}
\tkzInterLL(A',A'')(a,f)\tkzGetPoint{C}
\tkzInterLL(A',A'')(a,e)\tkzGetPoint{j}
\tkzInterLL(A',A'')(a,d)\tkzGetPoint{z}
\tkzInterLL(f,d)(A,A'')\tkzGetPoint{a1}
\tkzInterLL(A,A')(d,c)\tkzGetPoint{a2}
\tkzDrawSegments(A'',T A,I A,H K,A' A',M C,B j,A'' a,z f,a1 c,a2 e,a f,e a,b b,c A,B B,C C,A)
\tkzDrawSegments[dashed](T,I H,K M,B j,C z,d a1,d d,a2)
\tkzDrawPoints[fill=black,size=3](A,A',I,A'',H,C)
\tkzLabelPoints[below](A',C,B)
\tkzLabelPoints[above](A'',A,I)
\tkzLabelPoints[right](H)
\tkzMarkAngles[size=0.8cm,arc=l](c,b,a)
\tkzLabelAngles[pos=0.5,rotate=30](c,b,a){$Oyz$}
\tkzMarkAngles[size=0.5cm,arc=l](f,d,a)
\tkzLabelAngles[pos=-0.2,rotate=30](f,d,a){$P$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 88,
    Title = "Hệ tọa độ Oxz với mặt phẳng P",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hệ tọa độ Oxz với mặt phẳng P, các điểm A, A', A'', I, H, C, B, M (tương tự item 87 nhưng với Oxz).",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_88.png",
    Code = @"\begin{tikzpicture}[scale=0.8,>=stealth, font=\footnotesize, line join=round, line cap=round]
\clip (-5,-2) rectangle (6,5);
%%%%%%%%%%%%%%%
\tkzDefPoints{-1/0/a,4/0/b,0/2/d,5/2/c,-2/3/e,-1/5/f,2/3/A,2/1/H,-1/3.5/I,0/0/O}
\coordinate (A') at ($(A)!2!(H)$);
\coordinate (A'') at ($(A)!2!(I)$);
\tkzInterLL(A,I)(e,f)\tkzGetPoint{T}
\tkzInterLL(A,H)(a,b)\tkzGetPoint{K}
\tkzInterLL(A',A'')(O,d)\tkzGetPoint{B}
\tkzInterLL(A',A'')(a,b)\tkzGetPoint{M}
\tkzInterLL(A',A'')(a,f)\tkzGetPoint{C}
\tkzInterLL(A',A'')(a,e)\tkzGetPoint{j}
\tkzInterLL(A',A'')(a,d)\tkzGetPoint{z}
\tkzInterLL(f,d)(A,A'')\tkzGetPoint{a1}
\tkzInterLL(A,A')(d,c)\tkzGetPoint{a2}
\tkzDrawSegments(A'',T A,I A,H K,A' A',M C,B j,A'' a,z f,a1 c,a2 e,a f,e a,b b,c A,B B,C C,A)
\tkzDrawSegments[dashed](T,I H,K M,B j,C z,d a1,d d,a2)
\tkzDrawPoints[fill=black,size=3](A,A',I,A'',H,C)
\tkzLabelPoints[below](A',C,B)
\tkzLabelPoints[above](A'',A,I)
\tkzLabelPoints[right](H)
\tkzMarkAngles[size=0.8cm,arc=l](c,b,a)
\tkzLabelAngles[pos=0.5,rotate=30](c,b,a){$Oxz$}
\tkzMarkAngles[size=0.5cm,arc=l](f,d,a)
\tkzLabelAngles[pos=-0.2,rotate=30](f,d,a){$P$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 89,
    Title = "Hình hộp với tam giác ABC vuông góc",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình hộp với tam giác ABC, BH⊥C và AC⊥B, các điểm P, Q.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_89.png",
    Code = @"\begin{tikzpicture}[scale=0.6]
\tkzDefPoints{0/0/I, 5/0/Y, 2/2/U, 7/2/V, 0/3/z, 1.7/1/A', 4/3/B', 4/1/H', 6/1.5/C', 0.3/0.79/P}
\coordinate (J) at ($(I)+(z)$); 
\coordinate (N) at ($(Y)+(z)$);
\coordinate (M) at ($(U)+(z)$);
\coordinate (X) at ($(V)+(z)$);
\coordinate (A) at ($(A')+(z)$);
\coordinate (B) at ($(B')+(z)$);
\coordinate (H) at ($(H')+(z)$);
\coordinate (C) at ($(C')+(z)$);
\coordinate (Q) at ($(P)+(z)$);
\tkzMarkAngles[arc=l,size=1.2 cm](N,J,M Y,I,U)
\tkzDrawPoints(A,B,H,C)
\tkzDrawSegments(I,Y Y,V V,U U,I J,N N,X X,M M,J A,H B,H H,C A,C B,C)
\tkzMarkRightAngle(B,H,C)\tkzMarkRightAngle(A,C,B)
\tkzLabelPoints[above](A,B,C)
\tkzLabelPoints[below](H)
\tkzLabelPoints(P,Q)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 90,
    Title = "Hình hộp với tam giác ABC (phiên bản 2)",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Tương tự item 89, hình hộp với tam giác ABC, các quan hệ vuông góc.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_90.png",
    Code = @"\begin{tikzpicture}[scale=0.6]
\tkzDefPoints{0/0/I, 5/0/Y, 2/2/U, 7/2/V, 0/3/z, 1.7/1/A', 4/3/B', 4/1/H', 6/1.5/C', 0.3/0.79/P}
\coordinate (J) at ($(I)+(z)$); 
\coordinate (N) at ($(Y)+(z)$);
\coordinate (M) at ($(U)+(z)$);
\coordinate (X) at ($(V)+(z)$);
\coordinate (A) at ($(A')+(z)$);
\coordinate (B) at ($(B')+(z)$);
\coordinate (H) at ($(H')+(z)$);
\coordinate (C) at ($(C')+(z)$);
\coordinate (Q) at ($(P)+(z)$);
\tkzMarkAngles[arc=l,size=1.2 cm](N,J,M Y,I,U)
\tkzDrawPoints(A,B,H,C)
\tkzDrawSegments(I,Y Y,V V,U U,I J,N N,X X,M M,J A,H B,H H,C A,C B,C)
\tkzMarkRightAngle(B,H,C)\tkzMarkRightAngle(A,C,B)
\tkzLabelPoints[above](A,B,C)
\tkzLabelPoints[below](H)
\tkzLabelPoints(P,Q)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 91,
    Title = "Hai mặt phẳng P và Q với điểm A, B, H",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hai mặt phẳng P và Q, điểm A, B, H thỏa AH⊥B, đường thẳng d.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_91.png",
    Code = @"\begin{tikzpicture}[scale=1,x=1cm,y=1cm,line join = round, line cap = round]
\tkzInit[xmin = -1, ymin=-3,xmax = 9,ymax=6]
\tkzClip
\tkzSetUpPoint[color=black,fill=white,size=10]
\tkzDefPoints{0/1/D,6/1/C,2/3/E,1/-1.5/A,3/5/B,3/-1/H,0/-2/M,6/-2/N,2/0/Q,3/1.8/I,3/1/J}
\tkzDefPointWith[colinear = at E](D,C) 
\tkzGetPoint{F}
\tkzDefPointWith[colinear = at Q](M,N) 
\tkzGetPoint{P}
\tkzDefPointWith[linear,K=2](A,H) 
\tkzGetPoint{d}
\tkzDrawSegments(D,C C,F E,F E,D B,I J,H M,N N,P P,Q Q,M A,H H,d)
\draw[dashed] (I)--(J);
\tkzDrawPoints(A,B,H)
\tkzMarkRightAngles[size=0.3](A,H,B)
\tkzLabelPoints[below left](A)
\tkzLabelPoints[above left](B)
\tkzLabelPoints[below right](H,d) 
\tkzMarkAngles[size=1.1](Q,P,N)
\tkzMarkAngles[size=1.1](E,F,C) 
\draw (7.3,3) node[anchor=north]{$P$};
\draw (7.3,0) node[anchor=north]{$Q$};
%\tkzLabelPoints[right](K)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 92,
    Title = "Hai mặt phẳng P và Q với điểm O, A, H",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hai mặt phẳng P và Q, điểm O, A, H thỏa OH⊥A, đường thẳng d.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_92.png",
    Code = @"\begin{tikzpicture}[scale=1,x=1cm,y=1cm,line join = round, line cap = round]
\tkzInit[xmin = -1, ymin=-3,xmax = 9,ymax=6]
\tkzClip
\tkzSetUpPoint[color=black,fill=white,size=10]
\tkzDefPoints{0/1/D,6/1/C,2/3/E,1/-1.5/O,3/5/A,3/-1/H,0/-2/M,6/-2/N,2/0/Q,3/1.8/I,3/1/J}
\tkzDefPointWith[colinear = at E](D,C) 
\tkzGetPoint{F}
\tkzDefPointWith[colinear = at Q](M,N) 
\tkzGetPoint{P}
\tkzDefPointWith[linear,K=2](O,H) 
\tkzGetPoint{d}
\tkzDrawSegments(D,C C,F E,F E,D A,I J,H M,N N,P P,Q Q,M O,H H,d)
\draw[dashed] (I)--(J);
\tkzDrawPoints(O,A,H)
\tkzMarkRightAngles[size=0.3](O,H,A)
\tkzLabelPoints[below left](O)
\tkzLabelPoints[above left](A)
\tkzLabelPoints[below right](H,d) 
\tkzMarkAngles[size=1.1](Q,P,N)
\tkzMarkAngles[size=1.1](E,F,C) 
\draw (7.3,3) node[anchor=north]{$P$};
\draw (7.3,0) node[anchor=north]{$Q$};
%\tkzLabelPoints[right](K)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 93,
    Title = "Hai mặt phẳng P, Q với đường thẳng Δ",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hai mặt phẳng P và Q, đường thẳng Δ, các điểm A, B, H, K thỏa các quan hệ vuông góc.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_93.png",
    Code = @"\begin{tikzpicture}[line join = round, line cap = round,font=\footnotesize,scale=0.8]
\coordinate (W1) at (0,0);
\coordinate (W2) at ($(W1)+(6,0)$); 
\coordinate (W4) at ($(W1)+(45:2.5cm)$); 
\coordinate (W3) at ($(W2)+(W4)-(W1)$);
\draw[fill = gray!5, opacity=20] (W1) --(W2) --(W3)--(W4) -- cycle;
\tkzMarkAngles[size=0.7cm,arc=l](W2,W1,W4)
\tkzLabelAngles[color=black,pos=0.4](W2,W1,W4){\footnotesize $P$}
\coordinate (W1) at (0,-4);
\coordinate (W2) at ($(W1)+(6,0)$); 
\coordinate (W4) at ($(W1)+(45:2.5cm)$); 
\coordinate (W3) at ($(W2)+(W4)-(W1)$);
\draw[fill = gray!5, opacity=20] (W1) --(W2) --(W3)--(W4) -- cycle;
\tkzMarkAngles[size=0.7cm,arc=l](W2,W1,W4)
\tkzLabelAngles[color=black,pos=0.4](W2,W1,W4){\footnotesize $Q$}
\coordinate (A) at (2,-3.25);
\coordinate (C) at (5,-3.75);
\coordinate (K) at ($(A)!0.3!(C)$);
\coordinate (B) at (4,-1);
\coordinate (H) at ($(B)+(0,-2)$);
\draw ($(A)!-0.2!(C)$)-- (C) node[right]{$\Delta$};
\tkzMarkRightAngles[size=0.3](A,K,B B,H,K)
\tkzDrawSegments(B,K B,H H,K)
\tkzDrawPoints[fill=black](A,B,H,K)
\tkzLabelPoints[above](A,B)
\tkzLabelPoints[right](H)
\tkzLabelPoints[below](K)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 94,
    Title = "Hai mặt phẳng P, Q với đường Δ (phiên bản 2)",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Tương tự item 93, hai mặt phẳng P và Q, đường Δ, các điểm A, B, H, K.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_94.png",
    Code = @"\begin{tikzpicture}[line join = round, line cap = round,font=\footnotesize,scale=0.8]
\coordinate (W1) at (0,0);
\coordinate (W2) at ($(W1)+(6,0)$); 
\coordinate (W4) at ($(W1)+(45:2.5cm)$); 
\coordinate (W3) at ($(W2)+(W4)-(W1)$);
\draw[fill = gray!5, opacity=20] (W1) --(W2) --(W3)--(W4) -- cycle;
\tkzMarkAngles[size=0.7cm,arc=l](W2,W1,W4)
\tkzLabelAngles[color=black,pos=0.4](W2,W1,W4){\footnotesize $P$}
\coordinate (W1) at (0,-4);
\coordinate (W2) at ($(W1)+(6,0)$); 
\coordinate (W4) at ($(W1)+(45:2.5cm)$); 
\coordinate (W3) at ($(W2)+(W4)-(W1)$);
\draw[fill = gray!5, opacity=20] (W1) --(W2) --(W3)--(W4) -- cycle;
\tkzMarkAngles[size=0.7cm,arc=l](W2,W1,W4)
\tkzLabelAngles[color=black,pos=0.4](W2,W1,W4){\footnotesize $Q$}
\coordinate (A) at (2,-3.25);
\coordinate (C) at (5,-3.75);
\coordinate (K) at ($(A)!0.3!(C)$);
\coordinate (B) at (4,-1);
\coordinate (H) at ($(B)+(0,-2)$);
\draw ($(A)!-0.2!(C)$)-- (C) node[right]{$\Delta$};
\tkzMarkRightAngles[size=0.3](A,K,B B,H,K)
\tkzDrawSegments(B,K B,H H,K)
\tkzDrawPoints[fill=black](A,B,H,K)
\tkzLabelPoints[above](A,B)
\tkzLabelPoints[right](H)
\tkzLabelPoints[below](K)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 95,
    Title = "Hai đường thẳng Δ, Δ' với khoảng cách a, b",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hai đường thẳng Δ và Δ', điểm M, các điểm H, K, H₀, K₀, khoảng cách a và b.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_95.png",
    Code = @"\begin{tikzpicture}[scale=0.8, font=\footnotesize, line join=round, line cap=round, >=stealth]
\coordinate (A) at (0,0);\coordinate (B) at (6,0);\coordinate (C) at (-1,2);\coordinate (D) at (3,5);\coordinate (M) at (4.5,4);\coordinate (H) at ($(A)!1/2!(B)$);\coordinate (K) at ($(C)!3/4!(D)$);\coordinate (H0) at ($(A)!1/4!(B)$);\coordinate (K0) at ($(C)!1/4!(D)$);
\draw (A) -- (B) (C) -- (D) (M) -- (H) (M) -- (K) (K) -- (H) (K0) -- (H0);
\path 
(B) node[right] {$\Delta$} 
(D) node[above] {$\Delta '$}
(M) node[right] {$M$}
(H) node[below] {$H$}
(H0) node[below] {$H_0$} 
(K) node[above left] {$K$}
(K0) node[above left] {$K_0$}
(3.4,4.1)node[above] {$b$}
(3.7,2)node[right] {$a$};
\tkzMarkRightAngles[](B,H,M M,K,D H0,K0,D K0,H0,A)
\tkzDrawPoints[fill=black](M,H,H0,K,K0)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 96,
    Title = "Hai đường thẳng Δ, Δ' (phiên bản 2)",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Tương tự item 95, hai đường thẳng Δ và Δ', điểm M, H, K, H₀, K₀.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_96.png",
    Code = @"\begin{tikzpicture}[scale=0.8, font=\footnotesize, line join=round, line cap=round, >=stealth]
\coordinate (A) at (0,0);\coordinate (B) at (6,0);\coordinate (C) at (-1,2);\coordinate (D) at (3,5);\coordinate (M) at (4.5,4);\coordinate (H) at ($(A)!1/2!(B)$);\coordinate (K) at ($(C)!3/4!(D)$);\coordinate (H0) at ($(A)!1/4!(B)$);\coordinate (K0) at ($(C)!1/4!(D)$);
\draw (A) -- (B) (C) -- (D) (M) -- (H) (M) -- (K) (K) -- (H) (K0) -- (H0);
\path 
(B) node[right] {$\Delta$} 
(D) node[above] {$\Delta '$}
(M) node[right] {$M$}
(H) node[below] {$H$}
(H0) node[below] {$H_0$} 
(K) node[above left] {$K$}
(K0) node[above left] {$K_0$}
(3.4,4.1)node[above] {$b$}
(3.7,2)node[right] {$a$};
\tkzMarkRightAngles[](B,H,M M,K,D H0,K0,D K0,H0,A)
\tkzDrawPoints[fill=black](M,H,H0,K,K0)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 97,
    Title = "Hệ tọa độ Oxz với các điểm A, A', B, M, I",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hệ tọa độ Oxz, các điểm A, A', B, M (trung điểm), I, các giao tuyến với mặt phẳng.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_97.png",
    Code = @"\begin{tikzpicture}[scale=0.7, line join=round, line cap=round]
\tkzDefPoints{0/0/H,1/2/N,7/2/P,6/0/Q,2/3/A,2/1/I,5/3/B}
\coordinate (A') at ($(I)!-1!(A)$);
\coordinate (M) at ($(A')!0.5!(B)$);
\tkzInterLL(A,I)(N,P)\tkzGetPoint{E}
\tkzInterLL(B,A')(N,P)\tkzGetPoint{F}
\tkzInterLL(A,I)(H,Q)\tkzGetPoint{T}
\tkzInterLL(A',B)(H,Q)\tkzGetPoint{G}
\tkzInterLL(A,M)(N,P)\tkzGetPoint{J}
\tkzDrawSegments(H,N N,E J,P P,Q Q,H A,I B,M A,M T,A' G,A')
\tkzDrawSegments[dashed](E,J T,G M,G I,T)
\tkzDrawPoints[size=5,fill=black](A,B,I,A',M)
\tkzMarkAngles[size=1cm](Q,H,N)
\tkzLabelAngles[pos=0.6,rotate=30](Q,H,N){\footnotesize$Oxz$}
\tkzLabelPoints[below](A')
\tkzLabelPoints[below right](M)
\tkzLabelPoints[above](A,B)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 98,
    Title = "Hệ tọa độ Oxy với các điểm A, B, B', I, M",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hệ tọa độ Oxy, các điểm A, B, B', I, M trong không gian, phép tịnh tiến và đồng dạng.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_98.png",
    Code = @"\begin{tikzpicture}[scale=0.7, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/P1, 7/0/P2, 2/2/P3, 2.5/-0.6/B, 6.5/1.5/M, 2.5/1/I}
\tkzDefPointBy[translation=from P1 to P2](P3) \tkzGetPoint{P4}
\tkzDefPointBy[translation=from B to I](I) \tkzGetPoint{B'}
\tkzInterLL(P1,P2)(B,I) \tkzGetPoint{J}
\tkzInterLL(P1,P2)(B,M) \tkzGetPoint{K}
\tkzInterLL(B',M)(P2,P4) \tkzGetPoint{H}
\tkzDefPointBy[homothety=center B' ratio 1.5](M)\tkzGetPoint{M'}
\tkzDefPointBy[homothety=center B' ratio 0.4](M)\tkzGetPoint{A}
\tkzDrawPoints[fill=black](B,M,I,B',A)
\tkzDrawSegments(P1,P2 P1,P3 P3,P4 P2,P4 B',I B,J B,K B',M H,M')
\tkzDrawSegments[dashed](I,J M,K H,M)
\node at (0.5,0.3) [right]{$(Oxy)$};
\tkzLabelPoints[left](B)
\tkzLabelPoints[below](M)
\tkzLabelPoints[above](A,B')
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 99,
    Title = "Hình thang Q với đường Δ và các điểm vuông góc",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình thang Q với đường Δ, đường thẳng d, các điểm A, H, K thỏa AH⊥K và AK⊥d.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_99.png",
    Code = @"\begin{tikzpicture}[>=stealth,line join=round,line cap=round,font=\footnotesize,scale=1]
\tkzInit[ymin=0,ymax=4,xmin=0,xmax=4]\tkzClip
\tkzDefPoints{0/0/a,1/2/b,1.8/2/E,2.8/2/F,3/0/d,1.4/0.8/K,2.7/0.8/H,1.4/3.4/B,2.7/3.4/A,1.1/0.96/s}
\coordinate (c) at ($(b)+(d)-(a)$);
\tkzDrawLines[add = 0.7 and 3.9](s,K)
\tkzDrawLines[add = 0.65 and 0.45](B,A)
\tkzDrawSegments(a,b c,d d,a K,A A,H b,E F,c H,K)
\tkzDrawSegments[dashed](E,F)
\tkzDrawPoints[fill=black](K,H,A)
\tkzLabelPoints[below](H,K)
\tkzLabelPoints[above](A)
\draw (0.8,3.4) node[above]{$\Delta$};
\draw (0.7,1.3) node[right]{$d$};
\tkzMarkRightAngle[size=0.2](A,H,K)
\tkzMarkRightAngle[size=0.2](A,K,s)
\tkzMarkAngle[size=0.8](d,a,b)
\tkzLabelAngle[pos=0.5](b,a,d){$Q$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 100,
    Title = "Hình thang Q với Δ, d (phiên bản 2)",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Tương tự item 99, hình thang Q với đường Δ, d, các điểm A, H, K.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_100.png",
    Code = @"\begin{tikzpicture}[>=stealth,line join=round,line cap=round,font=\footnotesize,scale=1]
\tkzInit[ymin=0,ymax=4,xmin=0,xmax=4]\tkzClip
\tkzDefPoints{0/0/a,1/2/b,1.8/2/E,2.8/2/F,3/0/d,1.4/0.8/K,2.7/0.8/H,1.4/3.4/B,2.7/3.4/A,1.1/0.96/s}
\coordinate (c) at ($(b)+(d)-(a)$);
\tkzDrawLines[add = 0.7 and 3.9](s,K)
\tkzDrawLines[add = 0.65 and 0.45](B,A)
\tkzDrawSegments(a,b c,d d,a K,A A,H b,E F,c H,K)
\tkzDrawSegments[dashed](E,F)
\tkzDrawPoints[fill=black](K,H,A)
\tkzLabelPoints[below](H,K)
\tkzLabelPoints[above](A)
\draw (0.8,3.4) node[above]{$\Delta$};
\draw (0.7,1.3) node[right]{$d$};
\tkzMarkRightAngle[size=0.2](A,H,K)
\tkzMarkRightAngle[size=0.2](A,K,s)
\tkzMarkAngle[size=0.8](d,a,b)
\tkzLabelAngle[pos=0.5](b,a,d){$Q$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 101,
    Title = "Hệ tọa độ Oxy với phép tịnh tiến từ M₀ đến M",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hệ tọa độ Oxy, các điểm E, F, M, M₀, phép tịnh tiến vector từ M₀ đến M.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_101.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/A,1/2/B,7/2/C,6/0/D,4.5/3.5/E,3/1.4/M_0,4/0.6/M}
\coordinate (F) at ($(E)!1.8!(M_0)$);
\tkzInterLL(F,M)(A,D)\tkzGetPoint{I}
\tkzInterLL(E,M_0)(A,D)\tkzGetPoint{J}
\tkzInterLL(E,M_0)(B,C)\tkzGetPoint{H}
\tkzInterLL(E,M)(B,C)\tkzGetPoint{K}
\tkzDrawPoints[size=5,fill=black](E,F,M,M_0)
\tkzDrawSegments(A,B B,H K,C C,D D,A E,M E,M_0 J,F I,F)
\tkzDrawSegments[->,dashed](M,M_0)
\tkzDrawSegments[dashed](M_0,J M,I K,H)
\tkzMarkAngles[size=1cm](D,A,B)
\tkzLabelAngles[pos=0.5,rotate=30](D,A,B){\footnotesize$Oxy$}
\tkzLabelPoints[below](F,M)
\tkzLabelPoints[left](M_0)
\tkzLabelPoints[above](E)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 102,
    Title = "Hình thang P với đường thẳng d và các điểm vuông góc",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình thang P, đường thẳng d, các điểm A, H, K thỏa AH⊥K và AK⊥C.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_102.png",
    Code = @"\begin{tikzpicture}[scale=0.7, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/M,1/2/N,6/2/P,2/4/A,1.5/0.4/E,5.4/1.5/F,2/1.6/H}
\tkzDefPointBy[translation=from N to P](M) \tkzGetPoint{Q}
\tkzDefBarycentricPoint(E=4,F=1) \tkzGetPoint{B}
\tkzDefBarycentricPoint(E=1,F=4) \tkzGetPoint{C}
\tkzDefBarycentricPoint(E=4,F=5)\tkzGetPoint{K}
\tkzInterLL(N,P)(A,H) \tkzGetPoint{X}
\tkzInterLL(N,P)(A,K) \tkzGetPoint{Y}
\tkzDrawSegments(E,F A,K A,H H,K M,N N,X Y,P P,Q M,Q)
\tkzDrawSegments[dashed](X,Y)
\tkzDrawPoints[fill=black,size=5](A,K,H)
\tkzMarkRightAngle(A,H,K) 
\tkzMarkRightAngle(A,K,C) 
\tkzMarkAngle(Q,M,N)
\tkzLabelAngles[pos=0.6](Q,M,N){\tiny$P$}
\tkzLabelPoints[below,font=\footnotesize](K)
\tkzLabelPoints[below left,font=\footnotesize](H)
\tkzLabelPoints[above,font=\footnotesize](A)
\node[below] at (5,1.4) {$d$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 103,
    Title = "Hình bình hành P với tam giác AHB vuông tại H",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành P, tam giác AHB vuông tại H.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_103.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,font=\footnotesize,>=stealth,scale=0.75]
\fill (0,0) coordinate (x)
(4,0) coordinate (y)
(60:2) coordinate (t)
($(y)+(t)$) coordinate (z)
(40:2) coordinate [label=below:$A$](A) circle(1pt)
($(A)+(2,-0.5)$) coordinate [label=below:$H$] (H) circle(1pt)
($(H)+(0,3)$) coordinate [label=right:$B$] (B) circle(1pt);
\draw (x)--(y)--(z)--(t)--(x) (A)--(H)--(B)--(A);
\tkzMarkRightAngles[size=0.2](A,H,B)
\tkzMarkAngle[size=.8](y,x,t)
\draw (x) node[shift={(30:2ex)}]{$P$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 104,
    Title = "Hình thang P với các điểm A, B, C, H, K",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình thang P với các điểm A, B, C, H, K, các quan hệ vuông góc AH⊥K và AK⊥C.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_104.png",
    Code = @"\begin{tikzpicture}[scale=0.6, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/M,1/2/N,6/2/P,2/4/A,1.5/0.4/E,5.4/1.5/F,2/1.6/H}
\tkzDefPointBy[translation=from N to P](M) \tkzGetPoint{Q}
\tkzDefBarycentricPoint(E=4,F=1) \tkzGetPoint{B}
\tkzDefBarycentricPoint(E=1,F=4) \tkzGetPoint{C}
\tkzDefBarycentricPoint(E=4,F=5)\tkzGetPoint{K}
\tkzInterLL(N,P)(A,H) \tkzGetPoint{X}
\tkzInterLL(N,P)(A,K) \tkzGetPoint{Y}
\tkzDrawSegments(E,F A,K A,H H,K M,N N,X Y,P P,Q M,Q)
\tkzDrawSegments[dashed](X,Y)
\tkzDrawPoints[fill=black,size=5](A,K,H,B,C)
\tkzMarkRightAngle(A,H,K) 
\tkzMarkRightAngle(A,K,C) 
\tkzMarkAngle(Q,M,N)
\tkzLabelAngles[pos=0.6](Q,M,N){\tiny$P$}
\tkzLabelPoints[below,font=\footnotesize](B,K,C)
\tkzLabelPoints[below left,font=\footnotesize](H)
\tkzLabelPoints[above,font=\footnotesize](A)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 105,
    Title = "Hình bình hành P với vector pháp tuyến n̄ₚ",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình bình hành P với vector pháp tuyến n̄ₚ, các điểm M, H, M', đối xứng qua H.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_105.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/A,4/0/B,5/1.5/C,2/1/H,2/3/M}
\coordinate (D) at ($(A)+(C)-(B)$);
\coordinate (M') at ($(H)+(H)-(M)$);
\tkzInterLL(M,M')(A,B)\tkzGetPoint{I}
\tkzDrawPolygon(A,B,C,D)
\tkzDrawSegments(M,H I,M')
\tkzDrawSegments[dashed](H,I)
\draw[fill=black] (2,1) circle (1.5pt) (2,3) circle (1.5pt) (2,-1) circle (1.5pt);
\draw[->] (3.5,1.1)--(3.5,2.5) node[above right]{$\vec{n_P}$};
\tkzMarkAngles[size=0.7cm,arc=l](B,A,D)
\tkzLabelAngles[pos=0.45,rotate=10](B,A,D){$P$}
\tkzLabelPoints[right](M,M',H)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 106,
    Title = "Hình bình hành P với vector pháp tuyến (phiên bản 2)",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Tương tự item 105, hình bình hành P với vector pháp tuyến n̄ₚ.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_106.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round]
\tkzDefPoints{0/0/A,5/0/B,2/0/H,2/1.5/M}
\coordinate (M') at ($(H)+(H)-(M)$);
\tkzDrawSegments(A,B M,M')
\draw[fill=black] (2,0) circle (1.5pt) (2,1.5) circle (1.5pt) (2,-1.5) circle (1.5pt);
\draw[->] (2.5,0.3)--(4,0.3) node[above right]{$\vec{u_d}$};
\tkzLabelPoints[right](M,M')
\tkzLabelPoints[below right](H)
\tkzLabelSegment[pos=0.9,below right](A,B){$d$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 107,
    Title = "Đường tròn tâm O với đường thẳng d",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Đường tròn tâm O bán kính OA và OB, đường thẳng d, điểm M trên d, H là hình chiếu O lên d, OH⊥d.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_107.png",
    Code = @"\begin{tikzpicture}[line cap=round,line join=round,font=\footnotesize,>=stealth,scale=1]
\fill (0,0) coordinate [label=above left:$O$] (O) circle(1pt)
($(O)+(-25:2)$)coordinate [label=right:$A$] (A) circle(1pt)
($(O)+(100:2)$)coordinate [label=above:$B$] (B) circle(1pt)
($(A)!0.3!(B)$)coordinate [label=right:$M$] (M) circle(1pt)
($(A)!(O)!(B)$)coordinate [label=right:$H$] (H) circle(1pt);
\draw (O) circle (2) (A)--(O)--(B) (H)--(O)--(M);
\draw ($(A)!1.2!(B)$)--($(B)!1.3!(A)$) node[above,pos=1] {$d$};
\tkzMarkRightAngles[size=0.2](O,H,A)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 108,
    Title = "Hình thang P với các điểm A, H, K",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình thang P, các điểm A, H, K thỏa AH⊥K.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_108.png",
    Code = @"\begin{tikzpicture}[scale=0.6, font=\footnotesize, line join=round, line cap=round, >=stealth]
\tkzDefPoints{0/0/M,1/2/N,6/2/P,2/4/A,1.5/0.4/E,5.4/1.5/F,2/1.6/H}
\tkzDefPointBy[translation=from N to P](M) \tkzGetPoint{Q}
\tkzDefBarycentricPoint(E=4,F=5)\tkzGetPoint{K}
\tkzInterLL(N,P)(A,H) \tkzGetPoint{X}
\tkzInterLL(N,P)(A,K) \tkzGetPoint{Y}
\tkzDrawSegments(A,K A,H H,K M,N N,X Y,P P,Q M,Q)
\tkzDrawSegments[dashed](X,Y)
\tkzDrawPoints[fill=black,size=5](A,K,H)
\tkzMarkRightAngle(A,H,K) 
\tkzMarkAngle(Q,M,N)
\tkzLabelAngles[pos=0.6](Q,M,N){\tiny$P$}
\tkzLabelPoints[below,font=\footnotesize](K)
\tkzLabelPoints[below left,font=\footnotesize](H)
\tkzLabelPoints[above,font=\footnotesize](A)
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 109,
    Title = "Đường thẳng d với Δ₁ và Δ₂",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Đường thẳng d, hai đường thẳng Δ₁ và Δ₂, các điểm M, A, B.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_109.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/X,5/0/d, 2/0/A, 4/0/B, 3/2/K,1/0/M,1/-1/E}
\tkzDrawSegments(X,d B,K A,E)
\tkzDrawPoints[size=5,fill=black](M,A,B)
\tkzLabelPoints[above](A,M,d)
\tkzLabelPoints[below](B)
\tkzLabelSegment[pos=0.8,above right](B,K){$\Delta_2$}
\tkzLabelSegment[pos=0.8,below right](A,E){$\Delta_1$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 110,
    Title = "Đường thẳng d với Δ₁, Δ₂ và vector ū₂",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Đường thẳng d, Δ₁ và Δ₂, các điểm M, A, vector ū₂ của đường thẳng Δ₂.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_110.png",
    Code = @"\begin{tikzpicture}[scale=1, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/X,5/0/d, 3/0/A, 4/0.5/H, 4/2/K,1/0/M,1/-1/E}
\tkzDrawSegments(X,d H,K A,E)
\tkzDrawPoints[size=5,fill=black](M,A)
\tkzLabelPoints[below](A,M,d)
\tkzLabelSegment[pos=0.8,right](H,K){$\Delta_2$}
\tkzLabelSegment[pos=0.8,below right](A,E){$\Delta_1$}
\draw[->,blue] (1,0.2)--(3,0.2);
\draw[->,violet] (3.7,0.7)--(3.7,1.5) node[left]{$\vec{u}_2$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 111,
    Title = "Đoạn vuông góc chung HK của d₁ và d₂",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hai đường thẳng chéo nhau d₁ và d₂, HK là đoạn vuông góc chung, HK⊥d₁ và HK⊥d₂.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_111.png",
    Code = @"\begin{tikzpicture}[scale=0.7, line join=round, line cap=round]
\tkzDefPoints{0/0/A,5/-1/B,1/2/C,4/3.5/D}
\coordinate (H) at ($(A)!0.6!(B)$);
\coordinate (K) at ($(C)!0.4!(D)$);
\tkzDrawPoints[size=5,fill=black](H,K)
\tkzDrawSegments(A,B D,C H,K)
\tkzLabelPoints[below](H)
\tkzLabelPoints[above](K)
\tkzMarkRightAngle[size=0.2](H,K,C)
\tkzMarkRightAngle[size=0.2](K,H,B)
\tkzLabelSegment[pos=0.8,below right](A,B){$d_1$}
\tkzLabelSegment[pos=0.8,below right](C,D){$d_2$}
\node[below ] at (3,-2) {$HK$ là đoạn vuông góc chung của $d_1$ và $d_2$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 112,
    Title = "Khoảng cách từ điểm M đến đường thẳng d",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Đường thẳng d, điểm M, H là hình chiếu của M lên d, M₀ trên d, MH là khoảng cách từ M đến d.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_112.png",
    Code = @"\begin{tikzpicture}[smooth,samples=300,scale=0.8,>=stealth,font=\footnotesize]
\draw (-1,0)--(5,0) node[below]{$d$};
\draw (2,0)node[below]{$H$}--(2,3) node[right]{$M$};
\draw[fill=black] (2,0) circle(1.5pt) (2,3) circle(1.5pt) (1,0) circle(1.5pt);
\node[below] at (1,0) {$M_0$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 113,
    Title = "Mặt phẳng P với hai vector pháp tuyến n̄ và n̄'",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Mặt phẳng P với hai vector pháp tuyến n̄ và n̄' cùng phương.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_113.png",
    Code = @"\begin{tikzpicture}[scale=0.8, line join=round, line cap=round,>=stealth]
\tkzDefPoints{0/0/A,4/0/B,5/2/C}
\coordinate (D) at ($(A)+(C)-(B)$);
\tkzDrawPolygon(A,B,C,D)
\tkzMarkAngles[size=0.7cm,arc=l](B,A,D)
\tkzLabelAngles[pos=0.5,rotate=10](B,A,D){\scriptsize$P$}
\draw[->] (2,1)--(2,2.5)node[right]{\scriptsize$\vec{n}$};
\draw[->] (3,1.5)--(3,3)node[right]{\scriptsize$\vec{n'}$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 114,
    Title = "Khoảng cách từ điểm M đến mặt phẳng P",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Mặt phẳng P, điểm M, H là hình chiếu của M lên P, MH là khoảng cách từ M đến P.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_114.png",
    Code = @"\begin{tikzpicture}[scale=0.8, line join=round, line cap=round]
\tkzDefPoints{0/0/A,4/0/B,5/2/C}
\coordinate (D) at ($(A)+(C)-(B)$);
\tkzDrawPolygon(A,B,C,D)
\tkzMarkAngles[size=0.7cm,arc=l](B,A,D)
\tkzLabelAngles[pos=0.5,rotate=10](B,A,D){$P$}
\draw (2,1)node[right]{$H$}--(2,3)node[above]{$M$};
\draw[fill=black] (2,1) circle(1.5pt) (2,3) circle(1.5pt);
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 115,
    Title = "Hệ trục tọa độ Oxyz",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hệ trục tọa độ Oxyz với gốc O, ba trục x, y, z, các điểm A, B, C.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_115.png",
    Code = @"\begin{tikzpicture}[line width=0.6pt,>=stealth,scale=0.8]
\coordinate (O) at (0,0);
\coordinate (A) at (1,-1);
\coordinate (B) at (3,0);
\coordinate (C) at (0,2);
\draw (C)--(O)--(A)--(C)--(B)--(A);
\draw[->] (A)--(1.5,-1.5) node[below]{$x$};
\draw[->] (B)--(4,0) node[below]{$y$};
\draw[->] (C)--(0,2.8) node[left]{$z$};
\draw[dashed] (O)--(B);
\draw[fill=black] (O) circle(1pt) node[left]{$O$};
\draw[fill=black] (A) circle(1pt) node[below left]{$A$};
\draw[fill=black] (B) circle(1pt) node[above right]{$B$};
\draw[fill=black] (C) circle(1pt) node[left]{$C$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 116,
    Title = "Đường thẳng d với hai vector chỉ phương ū và ū'",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Đường thẳng d, hai vector chỉ phương ū và ū' cùng phương với d.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_116.png",
    Code = @"\begin{tikzpicture}[scale=0.8, line join=round, line cap=round,>=stealth]
\draw[thick] (0,0)--(4,0)node[below right]{$d$};
\draw[->,blue] (1,1)--(3,1)node[below]{\scriptsize$\vec{u}$};
\draw[->,violet] (2.3,1.5)--(3.7,1.5)node[above]{\scriptsize$\vec{u'}$};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 117,
    Title = "Hệ Oxy với M, I, M' và MM'⊥MI",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hệ tọa độ Oxy, các điểm M(-1;-2;0), I(-1;-2;11/4), M', MM'⊥MI.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_117.png",
    Code = @"\begin{tikzpicture}[scale=0.9, font=\footnotesize, line join=round, line cap=round, >=stealth]
\path
(2.5,2) coordinate (A)
(0.5,0) coordinate (B)
(5,0) coordinate (C)
(7,2) coordinate (D)
(3,1) coordinate (M)node[below]{$ M(-1;-2;0) $}
(3,4) coordinate (I)node[above]{$ I(-1;-2;\dfrac{11}{4}) $}
(5,1) coordinate (M')node[right]{$ M' $}
;
\begin{scope}
\clip (C)--(B)--(A);
\draw[fill=cyan!20] (B) circle(1.3cm)
node[shift={(15:0.7cm)}]{$Oxy$};
14 \end{scope}
\draw (A)--(B)--(C)--(D)--cycle
(M')--(M)--(I)
pic [draw=red,fill=yellow!30,angle radius=4mm] {right angle = M'--M--I}
;
\draw[dashed](I)--(M');
\foreach \p/\r in {M',M,I}
\draw[fill=white] (\p) circle (1.5pt) ;
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 118,
    Title = "Hệ Oxy với M(1;3;0), I(1;3;3), M'",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hệ tọa độ Oxy, các điểm M(1;3;0), I(1;3;3), M', M'M⊥MI.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_118.png",
    Code = @"\begin{tikzpicture}[scale = 1, font=\footnotesize, line join = round, line cap = round,>=stealth]
\def\a{5}
\def\b{3}
\def\g{30}
\path
(0,0) coordinate (A) --++(\a,0) coordinate (B)--++(\g:\b)coordinate (C)--++(-\a,0) coordinate (D)
($(A)!0.4!(C)$) coordinate (M)--++(\a*0.4,0)coordinate(M')
($(M)!1!90:(M')$) coordinate (I);
\draw (A)--(B)--(C)--(D)--cycle (I)--(M)--(M');
\draw [dashed] (M')--(I);
\fill[black] (M) circle (2pt) (M) node[below] {$M(1;3;0)$};
\fill[black] (M') circle (2pt) (M') node[right] {$M'$};
\fill[black] (I) circle (2pt) (I) node[above] {$I(1;3;3)$};
\draw pic[draw,angle radius = 15mm]{angle = B--A--D};
\node at ($(A)+(14:11mm)$) {$Oxy$};
\draw pic[draw, angle radius = 3mm]{right angle = M'--M--I};
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 119,
    Title = "Hình chóp S với các quan hệ vuông góc",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình chóp SABCD với góc α, các điểm S, H, K, M, N thỏa SH⊥K, SK⊥N, HK⊥M.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_119.png",
    Code = @"\begin{tikzpicture}[scale=0.7, line join=round, line cap=round]
\tkzDefPoints{0/0/A,1/2/B,6/2/C,5/0/D,5/2/N,3/0/M,2/1/H,4/1/K}
\coordinate (S) at ($(H)+(0,3)$);
\tkzInterLL(B,C)(S,H)\tkzGetPoint{I}
\tkzInterLL(H,K)(S,M)\tkzGetPoint{T}
\tkzDrawSegments(A,B B,I N,C C,D A,D M,N S,N S,M S,H S,K H,T)
\tkzDrawSegments[dashed](I,N T,K)
\tkzDrawPoints[size=5,fill=black](S,H,K)
\tkzLabelPoints[above](S,N)
\tkzLabelPoints[below](K,H,M)
\tkzMarkAngles[size=0.6,arc=ll,mark=|](S,K,H)
\tkzMarkRightAngle[size=0.3](S,H,K)
\tkzMarkRightAngle[size=0.3](S,K,N)
\tkzMarkRightAngle[size=0.3](H,K,M)
\tkzMarkAngle[size=0.7](D,A,B)
\tkzLabelAngle[pos=0.4](D,A,B){$\alpha$}
\end{tikzpicture}"
},

new TikzItem2
{
    Id = 120,
    Title = "Hình minh họa Toán học",
    Category = "Mặt và đường trong hình học không gian",
    Description = "Hình vẽ minh họa nội dung Toán học.",
    ImagePath = "Mat_va_uong_trong_hinh_hoc_khong_gian/matvaduongtronghinhhockhonggian_120.png",
    Code = @"\begin{tikzpicture}[scale=0.7, line join=round, line cap=round]
\tkzDefPoints{0/0/A,1/2/B,6/2/C,5/0/D,2/1/H,4/1/M}
\coordinate (S) at ($(H)+(0,3)$);
\tkzInterLL(B,C)(S,H)\tkzGetPoint{I}
\tkzInterLL(B,C)(S,M)\tkzGetPoint{K}
\tkzDrawSegments(A,B B,I K,C C,D A,D H,M S,H S,M)
\tkzDrawSegments[dashed](I,K)
\tkzDrawPoints[size=5,fill=black](S,H,M)
\tkzLabelPoints[above](S)
\tkzLabelPoints[below](M,H)
\tkzMarkAngles[size=0.6,arc=ll,mark=|](S,M,H)
\tkzMarkRightAngle[size=0.3](S,H,M)
\tkzMarkAngle[size=0.7](D,A,B)
\tkzLabelAngle[pos=0.4](D,A,B){$\alpha$}
\end{tikzpicture}"
},

