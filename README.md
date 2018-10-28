# Virtual Exhibitions

VR Exhibitions on Vive. A hackathon prototype created at the [4th Swiss Open Cultural Data Hackathon](http://make.opendata.ch/wiki/event:2018-10). Read more about our project on the [Opendata Wiki](http://make.opendata.ch/wiki/project:virtual_3d_exhibition). This repository is more for the technically inclined people.

## Vision

The goal is to create a customizable
virtual exhibition space with a focus on GLAM datasets.

### Core Features

 * 3D world with virtual exhibitions
 * freely explorable rooms
 * exhibitions loaded via backend (see the backend's [repository](https://github.com/ppanopticon/virtual-exhibition-manager.git) )
 * audio-guides per exhibit and ambient sounds per room
 * real or custom scaled exhibitions


## Unity

**We use Unity 2017.4**

Set up your Unity and IDE as you wish.
IntelliJ Rider is recommended for everyone that uses IDEA / PyCharm on a regular basis.

**GIT & Unity**:
In Unity set meta files to be visible and textual via:

 * `Edit > Project Settings > Editor`
 1. Set `Version Control Mode` to `Visible Meta Files`
 2. Set `Asset Serialization Mode`to `Force Text`
 
These steps are taken from https://stackoverflow.com/a/18225479

## Project Structure

```
 /
 |
   + Assets/                    - All custom unity stuff in here
      |
      + Fonts/                  - Fonts files, if custom fonts are used
      |
      + Materials/              - Unity Materials, if materials are used
      |
      + Plugins/                - Plugins, such as the Rider plugin.
      |
      + Prefabs/                - Unity Prefabs, if if prefabs are used
      |
      + Resources/              - Runtime loaded Resources
        |
        + Materials/            - Unity3d Materials
        |
        + Objects/              - 3D Models
      |
      + Scenes/                 - Home of the scenes, e.g. 'Worlds'
      |
      + Scripts/                - Home of the scripts, e.g. the logic
    |
    + Library/                    - Unity Libraries
    |
    + ProjectSettings/            - Unity Project Settings
    |
    + UnityPackageManager/)       - Unity Management
 

```
 
## Getting Started

To start working on the project

 1. Start Unity3d
 2. On the start screen click the `Open` button
 3. Select this repository
 
**Note** For the prototype we used fonts and textures that are non-open source, thus
the aforementioned project structure, especially fonts and textures have to be added manually.

The appropriate scripts load the materials as we set it up in the prototype.
Thus to get the most out of the experience, we highly encourage to use materials
similar to the ones we used.
 
## Contributors

 * Ivan Giangreco
 * Ralph Gasser
 * Silvan Heller
 * Mahnaz Parian
 * Loris Sauter

