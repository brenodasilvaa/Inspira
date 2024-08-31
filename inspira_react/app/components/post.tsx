'use client'; // Mark this as a Client Component

import React from 'react';
import { Card, CardHeader, Button, Avatar, Box, CardContent, CardActionArea, CardMedia, Grid, Typography, Icon, TextField } from '@mui/material';
import { Label } from '@mui/icons-material';
import ReactPlayer from 'react-player';

interface ImageCardProps {
    title: string;
    description: string;
    imageUrl: string;
  }

const Post: React.FC<ImageCardProps> = ({ title, description, imageUrl }) => {

  const handleClick = () => {
    console.log('Card clicked!');
  };

  return (
    <Card sx={{alignContent:'center'}}>
      <CardHeader
        avatar={
          <Avatar alt="User Photo" src={imageUrl} />
        }
        title="Breno"
        subheader="September 14, 2016"
      />
      <CardContent sx={{display:'flex', flexDirection:'row'}} onClick={handleClick}>
      <Grid alignContent={'center'} container spacing={0.5}>
        <Grid xs={12} sm={6} md={6} lg={6} item>
        <CardMedia>
          {
            true ? (
              <ReactPlayer width={'100%'} height={'20vh'}  style={{objectFit:'cover'}} controls url='https://www.youtube.com/watch?v=NrgmdOz227I' />
            ) :
            <img src={imageUrl} alt={title} style={{ width: '100%', height: '20vh', objectFit:'cover' }} />
          }
        
      </CardMedia>
          <CardContent>
            <Typography variant="body2">{title}</Typography>
            <Typography variant="subtitle2" color="text.secondary">{description}</Typography>
          </CardContent>

        </Grid>

        <Grid xs={12} sm={6} md={6} lg={6} item>
        <CardMedia>
        {
            false ? (
              <video width="100%" height="20vh" controls>
              <source src="https://www.w3schools.com/html/mov_bbb.mp4" type="video/mp4" />
              Your browser does not support the video tag.
            </video>
            ) :
            <img src={'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25'} alt={title} style={{ width: '100%', height:'20vh', objectFit:'cover'}} />
          }
      </CardMedia>
          <CardContent>
          <Typography variant="body2">{title}</Typography>
          <Typography variant="subtitle2" color="text.secondary">{description}</Typography>
          </CardContent>
        </Grid>
      </Grid>
      </CardContent>
      <CardContent>
      <Box width={'100%'} sx={{whiteSpace: "pre-wrap"}}>
        <Typography variant='body1'>{description}</Typography>
      </Box>
      </CardContent>
    </Card>
  );
};

export default Post;