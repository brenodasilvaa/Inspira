'use client';

import React from 'react';
import { Grid, Box, ThemeProvider } from '@mui/material';
import CardPost from '../components/card-post';
import HomeLayout from './layout';
import theme from '../theme';

const cardsData = [
  { id: 1, title: 'First Image', description: 'Info about the first image', imageUrl: 'https://i.scdn.co/image/ab67616d0000b273dc30583ba717007b00cceb25' },
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

const HomePage = () => {
  return (
    <ThemeProvider theme={theme}>
    <HomeLayout>
      <Box sx={{ flexGrow: 1, display: 'flex', justifyContent: 'center' }}>
            <Grid margin={5} container spacing={3} justifyContent="center">
              {cardsData.map((card) => (
                <Grid
                  item
                  key={card.id}
                  xs={12} sm={6} md={4} lg={3}
                  display="flex"
                  justifyContent="center"
                  alignItems="center"
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
    </HomeLayout>
    </ThemeProvider>
   
   
  );
};

export default HomePage;
