'use client'; // Mark this as a Client Component

import React from 'react';
import { Card, CardHeader, Button, Avatar, Box, CardContent, CardActionArea, CardMedia, Grid, Typography } from '@mui/material';

interface ImageCardProps {
    title: string;
    description: string;
    imageUrl: string;
  }

const CardPost: React.FC<ImageCardProps> = ({ title, description, imageUrl }) => {

  const handleClick = () => {
    console.log('Card clicked!');
  };

  return (
    <Card>
      <CardHeader
        avatar={
          <Avatar alt="User Photo" src={"https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25"} />
        }
        title="Breno"
        subheader="September 14, 2016"
      />
      <CardActionArea onClick={handleClick}>
      <Grid container spacing={0.5}>
        <Grid item xs={6}>
          <CardMedia
            component="img"
            image= {imageUrl}
            alt="First Image"
            style={{ height: '100px', objectFit: 'cover' }}
          />
          <CardContent>
            <Typography variant="body2">{title}</Typography>
            <Typography variant="subtitle2" color="text.secondary">{description}</Typography>
          </CardContent>

        </Grid>

        <Grid item xs={6}>
          <CardMedia
            component="img"
            image="https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25"
            alt="Second Image"
            style={{ height: '100px', objectFit: 'cover' }}
          />
          <CardContent>
          <Typography variant="body2">{title}</Typography>
          <Typography variant="subtitle2" color="text.secondary">{description}</Typography>
          </CardContent>
        </Grid>
        <Box
        sx={{
          bottom: 0,
          left: 0,
          width: 'inherit'
        }}
      >
        <Button variant="contained" size="small" color="primary" fullWidth>
          Ver
        </Button>
      </Box>
      </Grid>
      </CardActionArea>
    </Card>
  );
};

export default CardPost;