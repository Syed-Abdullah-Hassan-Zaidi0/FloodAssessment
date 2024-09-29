# Flood Destruction Assessment in Larkana, Sukkur, and Shikarpur, Pakistan

## Overview

This project aims to assess the destruction caused by floods in the regions of Larkana, Sukkur, and Shikarpur, Pakistan, from 2018 to 2022. Utilizing advanced satellite data and robust data processing techniques, the project provides insights into the impact of floods on land cover, population, agriculture, and urban areas. The assessment leverages Landsat 8 and Sentinel-1/2 satellite data, processed through Google Earth Engine (GEE), and stores results in a structured database using SQL. A web application developed using .NET Blazor Server serves as the user interface for accessing and visualizing the analysis results.

## Table of Contents

- [Project Goals](#project-goals)
- [Technologies Used](#technologies-used)
- [Data Sources](#data-sources)
- [Methodology](#methodology)
- [Results](#results)
- [Web Application](#web-application)
- [Installation](#installation)
- [Usage](#usage)
- [Contributors](#contributors)

## Project Goals

The main goals of this project are:

- To assess the extent of flood damage in the target regions over the specified timeframe.
- To analyze changes in land cover due to flooding events.
- To evaluate the impact of floods on affected populations, crop land, and urban areas.
- To provide a user-friendly platform for stakeholders to visualize and interact with the data.

## Technologies Used

- **Satellite Data**: Landsat 8, Sentinel-1/2
- **Data Processing**: Google Earth Engine (GEE)
- **Database**: SQL for data storage and retrieval
- **Web Development**: .NET Blazor Server
- **Data Visualization**: Custom charts and graphs integrated into the web application

## Data Sources

- **Landsat 8**: Provides high-resolution satellite imagery for land cover analysis.
- **Sentinel-1/2**: Offers radar and optical data for assessing changes in land surface and vegetation.
- **Google Earth Engine**: Used for pre-processing and post-processing satellite data to ensure accuracy and consistency.

## Methodology

1. **Data Collection**: 
   - Gather Landsat 8 and Sentinel-1/2 satellite data covering Larkana, Sukkur, and Shikarpur from 2018 to 2022.
   
2. **Pre-processing**: 
   - Utilize Google Earth Engine for filtering, cloud masking, and normalizing the satellite images to prepare them for analysis.
   
3. **Post-processing**: 
   - Analyze the processed data to identify changes in land cover, population affected, crop land, and urban development.
   
4. **Data Storage**: 
   - Save the analysis results in a SQL database for efficient querying and management of the data.

5. **Visualization**: 
   - Develop a web application using .NET Blazor Server to present the analysis results interactively, allowing users to explore the impact of floods visually.

## Results

The analysis reveals significant changes in land cover and the extent of flood damage over the years. Key findings include:

- **Land Cover Change**: Identification of areas most affected by flooding and how land use has evolved post-disaster.
- **Population Impact**: Estimation of the number of people affected in different areas, with visual representations of affected zones.
- **Agricultural Damage**: Assessment of crop land loss and its implications for local agriculture.
- **Urban Impact**: Analysis of urban areas affected by floods and the resultant changes in infrastructure.

## Web Application

The web application built using .NET Blazor Server allows users to:

- View detailed maps and graphs illustrating the flood impact over time.
- Access raw data and insights derived from the analysis.
- Interact with the data through various filtering options to explore specific regions or timeframes.

## Installation

To run this project locally, follow these steps:

1. Clone this repository:
   ```bash
   git clone https://github.com/Syed-Abdullah-Hassan-Zaidi0/FloodAssessment.git
2. Navigate to the project directory:
    ```bash
    cd FloodAssessment
3. Set up the database:
   - Create a SQL database and execute the SQL script.

4. Run the web application:
   - Open the project in Visual Studio and start debugging.
     
# Usage
- Once the application is running, navigate to http://localhost:5000 to access the web interface.
- Users can explore various sections to view flood impact analysis, land cover changes, and other relevant data.

# Contributors
 Syed Abdullah Hassan Zaidi
