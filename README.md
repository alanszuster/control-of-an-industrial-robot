# 🤖 Industrial Robot Control Application

A Windows Forms desktop application for controlling industrial robots via serial communication (RS-232/RS-485). The program enables precise robot position control, jog movements, and real-time device status monitoring.

## ✨ Features

- **Serial Communication**: Full COM port support with connection parameter configuration
- **Robot Control**:
  - Jog movements for all robot axes (X, Y, Z, Pitch, Roll, Yaw)
  - Movement speed regulation
  - Gripper control (open/close)
  - "WHERE" command for position checking
- **User Interface**:
  - Intuitive control panel with directional buttons
  - Connection status indicator
  - Communication console for custom commands
  - DTR/RTS options for advanced port settings

## 🛠️ Requirements

- **Operating System**: Windows 7/8/10/11
- **.NET Framework**: 4.6.1 or newer
- **Hardware**: Serial port or USB-to-Serial adapter
- **Robot**: Compatible with communication protocol using DJ, GO, GC, WH commands

## 🚀 Installation

### Option 1: Run pre-built application

1. Download the latest version from [Releases](../../releases)
2. Run `Porty.exe`
3. Configure serial port parameters
4. Connect to the robot

### Option 2: Build from source

1. Clone the repository:

   ```bash
   git clone https://github.com/username/control-of-an-industrial-robot.git
   ```

2. Open `Porty.sln` in Visual Studio
3. Build the project (Ctrl+Shift+B)
4. Run the application

## 🎮 How to Use

### 1. Connection Setup

- Select the appropriate COM port from the dropdown list
- Set communication parameters (Baud Rate, Data Bits, Stop Bits, Parity)
- Click "Open" to establish connection

### 2. Robot Control

- Use directional buttons to move the robot
- Adjust speed using the "Jog Speed" slider
- Use "Open" and "Close" buttons to control the gripper
- Click "Where" to check the current robot position

### 3. Advanced Features

- Send custom commands through the "Data OUT" field
- Monitor robot responses in the "Data IN" field
- Configure DTR/RTS options as needed

## 🔧 Communication Protocol

The application uses the following commands:

| Command | Description | Example |
|---------|-------------|---------|
| `DJ axis,speed` | Move axis with specified speed | `DJ 1,50` |
| `GO` | Open gripper | `GO` |
| `GC` | Close gripper | `GC` |
| `WH` | Check position | `WH` |

### Axis Mapping

- Axis 1: Waist (base rotation)
- Axis 2: Shoulder (arm)
- Axis 3: Elbow
- Axis 4: Twist (wrist rotation)
- Axis 5: Pitch (wrist tilt)
- Axis 6: Roll (wrist roll)

## 📁 Project Structure

```text
├── Form1.cs              # Main application logic
├── Form1.Designer.cs     # Generated interface code
├── Form1.resx           # Form resources
├── Program.cs           # Application entry point
├── P.cs                 # Helper class
├── Porty.csproj         # Project file
├── Properties/          # Application properties
└── bin/Debug/           # Compiled application
```

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
