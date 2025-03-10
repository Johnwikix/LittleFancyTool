import os
import pytest
from pywinauto.application import Application
from pywinauto.timings import Timings
from pywinauto import mouse
from pywinauto import keyboard

Timings.window_find_timeout = 5

def get_exe_path():
    current_dir = os.path.dirname(os.path.abspath(__file__))
    project_root = os.path.dirname(current_dir)
    return os.path.join(
        project_root,
        "bin",
        "Debug",
        "net8.0-windows",
        "LittleFancyTool.exe"
    )

@pytest.fixture(scope="module")
def app():
    exe_path = get_exe_path()
    application = Application(backend="uia").start(exe_path)
    yield application
    # 测试结束后关闭应用
    # application.kill()

def test_controls_existence(app):
    main_window = app.window(title="妙妙小工具", auto_id="MainForm", control_type="Window")
    assert main_window.exists(), "Main window not found"
    assert main_window.is_visible(), "Main window not visible"

    button_collapse = main_window.child_window(auto_id="button_collapse", control_type="Pane")
    assert button_collapse.exists(), "button_collapse not found"
    rect = button_collapse.rectangle()
    center_x = (rect.left + rect.right) // 2
    center_y = (rect.top + rect.bottom) // 2
    print(f"控件坐标: {center_x,center_y}")
    mouse.click(coords=(center_x, center_y))

    input_search = main_window.child_window(auto_id="input_search", control_type="Pane")
    assert input_search.exists(), "input_search not found"
    rect_s = input_search.rectangle()
    main_window.print_control_identifiers()
    searchNMove(input_search,rect,"RSA")
    rsaGenKeyBtn = main_window.child_window(title="生成密钥", auto_id="rsaGenKeyBtn", control_type="Pane")
    assert rsaGenKeyBtn.exists(), "button_collapse not found"
    rect_rsaGen = rsaGenKeyBtn.rectangle()
    mouse.click(coords=((rect_rsaGen.left + rect_rsaGen.right)//2, (rect_rsaGen.top + rect_rsaGen.bottom)//2))
    rsaInputTextBox = main_window.child_window(auto_id="rsaInputTextBox", control_type="Pane")
    assert rsaInputTextBox.exists(), "button_collapse not found"
    rect_rsaInput = rsaInputTextBox.rectangle()
    mouse.click(coords=((rect_rsaInput.left + rect_rsaInput.right)//2, (rect_rsaInput.top + rect_rsaInput.bottom)//2))
    keyboard.send_keys("^a{DELETE}")
    keyboard.send_keys("RSATest")
    rsaEncryptBtn = main_window.child_window(title="加密>>", auto_id="rsaEncryptBtn", control_type="Pane")
    assert rsaEncryptBtn.exists(), "button_collapse not found"
    rect_rsaEn = rsaEncryptBtn.rectangle()
    mouse.click(coords=((rect_rsaEn.left + rect_rsaEn.right)//2, (rect_rsaEn.top + rect_rsaEn.bottom)//2))
    searchNMove(input_search,rect,"SM2")
    searchNMove(input_search,rect,"AES")
    searchNMove(input_search,rect,"DES")
    searchNMove(input_search,rect,"SM4")
    searchNMove(input_search,rect,"MD5")
    searchNMove(input_search,rect,"SHA")
    searchNMove(input_search,rect,"SM3")
    searchNMove(input_search,rect,"Base64")
    searchNMove(input_search,rect,"图片转Base64")
    searchNMove(input_search,rect,"文件加密")
    mouse.click(coords=((rect_s.left + rect_s.right)//2, (rect_s.top + rect_s.bottom)//2))
    keyboard.send_keys("^a{DELETE}")

def searchNMove(input_search,rect,text):
    center_x = (rect.left + rect.right) // 2
    center_y = (rect.top + rect.bottom) // 2
    rect_s = input_search.rectangle()
    mouse.click(coords=((rect_s.left + rect_s.right)//2, (rect_s.top + rect_s.bottom)//2))
    keyboard.send_keys("^a{DELETE}")
    keyboard.send_keys(text)
    mouse.click(coords=(center_x+50, center_y-750))
