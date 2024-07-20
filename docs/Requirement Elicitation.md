<!-- # Requirement Elicitation

## Methods

### Document Analysis

### Client Interview

## Process

**Note:** Currently available stakeholders are Shannon Rios (Client), Sable Wang (Project Mentor), and the VL-RedBack team.

## Requirement Collection

### Functional Requirement

### Non-Functional Requirement

### Emotional Requirement

Make sure that your Requirements Elicitation satisfies the following criteria:

- [ ] Explain your requirements elicitation methods and roles/responsibilities during the meeting with industry partner.
- [ ] The requirements elicitation methods must be effective in ensuring that the gathered requirements accurately reflect the expectations and needs of stakeholders.
- [ ] The requirements elicitation process should cover all stakeholders and their needs as comprehensively as possible to avoid overlooking important information.
- [ ] Requirements collected through various methods should be consistent to avoid contradictions or conflicts.
- [ ] Requirements must be clear and unambiguous to ensure the development team can accurately understand and implement them. -->

# Requirement Elicitation

## Requirement Elicitation Methods

To thoroughly understand the needs and expectations for the VR/AR education platform, we employed two primary elicitation methods: Document Analysis and Client Meetings (Interviews).

### Document Analysis
- **Procedure:** We began by thoroughly reviewing existing documentation related to VR/AR educational platforms, including technical specifications, user manuals, and academic research papers. This initial review helped us to draft a preliminary set of requirements.
- **Rationale:** Document Analysis provides us insights within the domain of VR/AR education. By researching previous applications, we can avoid reinventing the wheel. Additionally, this method helps us identify advanced practices, which are crucial for ensuring the platform's  effectiveness.
- **Outcome:** Based on our findings from document analysis, we developed an initial set of primitive requirements. These served as a foundation for further refinement through interaction with the client.

### Client Meeting (Interview)
- **Procedure:** Following the document analysis, we organized a series of client meetings, adopting an interview format. During the meetings, we presented the initial requirements derived from the document analysis and sought feedback to refine the requirements.
- **Rationale:** Direct interaction with stakeholders through interviews is invaluable for several reasons. First, it allows for the clarification and confirmation of the initial requirements, ensuring they accurately reflect the users' needs and expectations. Second, interviews provide a platform for the client to express concerns, preferences, and unique insights that may not be captured through document analysis. 
- **Roles/Responsibilities:** Interview session was structured to encourage open dialogue and productive discussion. The team responsible for conducting the interviews included a facilitator (Tianyi Zhong), who guided the conversation and ensured all relevant questions were covered, and a scribe (Keang Lyu), who documented the discussions for later analysis. 
- **Outcome:** The feedback and insights gathered during the client meetings were instrumental in refining the initial set of requirements. This process ensured that the final requirements were comprehensive, and aligned with the client's expectations.

### Why These Methods?

The combination of document analysis and client meetings (interviews) offers a balanced approach to requirement elicitation. Document analysis provides a solid theoretical foundation from existing literature and documentation. In contrast, client meetings offer real-world perspectives from the users. This dual approach ensures that the requirements are both grounded in research and deeply informed by the practical needs of the users.

## Requirement Elicitation Process

### Document Analysis

After reviewing existing documentation, we came up with a set of primitive requirements. Then we conducted a client meeting to solidify the requirements.

### Client Meeting （Interview)

- **Time spent:** 1 hour.
- **Meeting Purpose:**
  - Report on the current work content and clarify the requirements.
- **Start Time:** Mar 19, 2024 03:30 PM
- **Roles & Attendees:**
  - Facilitator & Product Owner: Tianyi Zhong
  - Scribe & Scrum Master: Keang Lyu
  - Sub-team Leader: Yinuo Li
  - Subteam Leader: Shanqing Huang
  - Member: Mo Cheng, Henagjia Cao, Mingyang Lai, Zhuyun Lu, Wenquan Wan
- **Location:** Zoom.

#### Agenda

- 3:30 - 3:35: **Introduction**
  - Introduce ourselves.
- 3:35 - 3:45: **Report Progress**
  - Report on the work we have done so far.
- 3:45 - 3:55: **Project Explanation**
  - Client and mentor provide an explanation of the project.
- 3:55 - 4:25: **Requirements Discussion**
  - Discuss the requirements of this project.
- 4:25 - 4:35: **Meeting Summary**
  - Summarize this client meeting.

#### Client Meeting Questions & Answers

Q1: Age of user group: Primary school, high school, or college?

- **A:** Higher education students

Q2: The discipline of students (users)?

- **A:** Engineering faculty

Q3: Based on any specific platform? Windows, Android…?

- **A:** No mandatory requirements

Q4:Based on any specific equipment? VR glasses…?

- **A:** The client can provide AR equipment, we can also directly use mouse and keyboard.

#### Note: Other details of this client meeting can be found in meetings/Client Meeting 1.md 

## Requirement Collection

### Functional Requirements

#### Environment Creation

- The system shall allow users to create rudimentary 3D environments using:
  - primitive elements (Lego-style)
  - imported 3D scanned/photogrammetry data.

#### Character Customization:

- Users should be able to create a player character and define its capabilities such as speed, jump, size, and control type (motion controls or on rails).

#### Content Integration

- The platform must support the insertion of content from external sources, including images, videos, and text, into the 3D environments created.

#### Interactivity

- Ensure that environments are fully interactable, allowing users to engage with and manipulate elements within the virtual space.
- Implementing multi-user interaction to enable collaboration and engagement among participants in the virtual learning experience.

### Non-functional Requirements

#### Performance

- The system shall ensure smooth performance and responsiveness while creating, editing, and navigating 3D environments.

#### Usability

- Provide an intuitive user interface, making the platform accessible to academics with limited VR/AR development training or experience.
- Ensuring ease of access and usability by making the project accessible via web browsers without the need for software installation on users' computers.

#### Scalability

- The system should be scalable to accommodate future updates, additional features, and increased user activity.

#### Security

- Data security measures must be implemented to protect user-generated content and ensure user privacy.

### Emotional Requirements

#### Empowering Experience

- Users should feel empowered and confident in their ability to create engaging virtual learning experiences, despite their level of expertise.

#### Inspiration and Creativity

- Fostering an environment that promotes creativity and inspiration, drawing inspiration from platforms like Roblox and Minecraft to encourage innovative content creation and immersive educational experiences.

#### Engagement and Satisfaction

- Interactions with the system should evoke feelings of engagement, satisfaction, and accomplishment, fostering a positive user experience.

## Follow Up After Elicitation

1. Classify the information we have collected from the client.
2. Organize and analyze these data, and then discuss with the client to agree on specific requirements.
3. Conduct further analysis of these requirements, creating a goal model, personas and user stories.
