import tkinter as tk

window = tk.Tk()
window.title("Double Integral Area Visualizer")
window.geometry("950x700")

canvas = tk.Canvas(
    window,
    width=700,
    height=650,
    bg="white"
)

canvas.pack(side="left", padx=10, pady=10)

ORIGIN_X = 100
ORIGIN_Y = 550
SCALE = 100

def sx(x):
    return ORIGIN_X + x * SCALE

def sy(y):
    return ORIGIN_Y - y * SCALE

def bottom(x):
    return x**2

def top(x):
    return 4

def draw_grid():

    for x in range(-1,6):

        px = sx(x)

        canvas.create_line(
            px,50,
            px,600,
            fill="#dddddd"
        )

        canvas.create_text(
            px,
            ORIGIN_Y+25,
            text=str(x),
            font=("Arial",10)
        )

    for y in range(0,6):

        py = sy(y)

        canvas.create_line(
            50,py,
            650,py,
            fill="#dddddd"
        )

        canvas.create_text(
            ORIGIN_X-25,
            py,
            text=str(y),
            font=("Arial",10)
        )

    canvas.create_line(
        50,
        ORIGIN_Y,
        650,
        ORIGIN_Y,
        width=3
    )

    canvas.create_line(
        ORIGIN_X,
        600,
        ORIGIN_X,
        50,
        width=3
    )

    canvas.create_polygon(
        650,ORIGIN_Y,
        635,ORIGIN_Y-8,
        635,ORIGIN_Y+8,
        fill="black"
    )

    canvas.create_polygon(
        ORIGIN_X,50,
        ORIGIN_X-8,65,
        ORIGIN_X+8,65,
        fill="black"
    )

    canvas.create_text(
        660,
        ORIGIN_Y,
        text="x",
        font=("Arial",14)
    )

    canvas.create_text(
        ORIGIN_X,
        35,
        text="y",
        font=("Arial",14)
    )

def draw():

    canvas.delete("all")

    draw_grid()

    points=[]

    x=0

    while x<=2:

        points.append(
            (
                sx(x),
                sy(top(x))
            )
        )

        x+=0.02

    x=2

    while x>=0:

        points.append(
            (
                sx(x),
                sy(bottom(x))
            )
        )

        x-=0.02

    flat=[]

    for p in points:
        flat.extend(p)

    canvas.create_polygon(
        flat,
        fill="#b3e5fc",
        outline=""
    )

    x=0

    while x<2:

        nx=x+.02

        canvas.create_line(
            sx(x),
            sy(bottom(x)),
            sx(nx),
            sy(bottom(nx)),
            fill="blue",
            width=3
        )

        canvas.create_line(
            sx(x),
            sy(4),
            sx(nx),
            sy(4),
            fill="green",
            width=3
        )


        x=nx

    canvas.create_line(
        sx(0),
        sy(0),
        sx(0),
        sy(4),
        fill="purple",
        width=3
    )

    canvas.create_line(
        sx(2),
        sy(0),
        sx(2),
        sy(4),
        fill="purple",
        width=3
    )

    n = slider.get()

    dx = 2/n

    area=0

    for i in range(n):

        left=i*dx

        mid=left+dx/2


        height=top(mid)-bottom(mid)

        area += height*dx

        canvas.create_rectangle(
            sx(left),
            sy(top(mid)),
            sx(left+dx),
            sy(bottom(mid)),
            fill="#ffcc80",
            outline="red"
        )

    area_label.config(
        text=f"Area ≈ {area:.5f}"
    )

panel=tk.Frame(window)

panel.pack(
    side="right",
    padx=20
)

title=tk.Label(
    panel,
    text="Double Integral\nVisualizer",
    font=("Arial",18,"bold")
)

title.pack(pady=10)

info=tk.Label(
    panel,
    text=
    "Region:\n"
    "0 ≤ x ≤ 2\n"
    "x² ≤ y ≤ 4\n\n"
    
    "Integral:\n"
    "∫₀² ∫ₓ²⁴ 1 dy dx",
    
    font=("Arial",14),
    justify="left"
)

info.pack()

slider=tk.Scale(
    panel,
    from_=5,
    to=80,
    orient="horizontal",
    label="Rectangles",
    command=lambda x:draw()
)

slider.set(20)

slider.pack(pady=20)

area_label=tk.Label(
    panel,
    text="",
    font=("Arial",14,"bold")
)

area_label.pack()

legend=tk.Label(
    panel,
    text=
    "Legend:\n\n"
    "Blue: y=x²\n"
    "Green: y=4\n"
    "Orange: rectangles\n"
    "Purple: x bounds",
    font=("Arial",12),
    justify="left"
)

legend.pack(pady=30)

draw()

window.mainloop()