'use client';

import React from 'react';
import { Grid, Box, ThemeProvider } from '@mui/material';
import CardPost from '../components/card-post';

const cardsData = [
  { id: 1, title: 'First Image', description: `sdfsdfsdf


    ffff
    `, imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' },
  { id: 2, title: 'Second Image', description: 'Info about the second image', imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' },
  { id: 3, title: 'Third Image', description: 'Info about the third image', imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' },
  { id: 4, title: 'Fourth Image', description: 'Info about the fourth image', imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' },
  { id: 5, title: 'Fourth Image', description: 'Info about the fourth image', imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' },
  { id: 4, title: 'Fourth Image', description: 'Info about the fourth image', imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' },
  { id: 4, title: 'Fourth Image', description: 'Info about the fourth image', imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' },
  { id: 4, title: 'Fourth Image', description: 'Info about the fourth image', imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' },
  { id: 4, title: 'Fourth Image', description: 'Info about the fourth image', imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' },
  { id: 4, title: 'Fourth Image', description: 'Info about the fourth image', imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' }
];

const Cards = () => {
  return (
      <Box sx={{ flexGrow: 1, display: 'flex', justifyContent: 'center' }}>
            <Grid marginTop={5} container>
              {cardsData.map((card) => (
                <Grid
                  item
                  key={card.id}
                  xs={12} sm={6} md={4} lg={3}
                  display="flex"
                  justifyContent="center"
                  alignItems="center"
                  marginTop={1}
                  padding={1}
                >
                  <CardPost 
                    title={card.title} 
                    description={card.description} 
                    imageUrl={card.imageUrl} 
                  />
                </Grid>
              ))}
            </Grid>
        </Box>  
  );
};

export default Cards;
