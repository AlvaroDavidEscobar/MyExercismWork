
export const frontDoorResponse = (line) => line[0];

export const frontDoorPassword = (word) => word[0].toUpperCase() + word.slice(1).toLowerCase();

export const backDoorResponse = (line) => line.trim()[line.trim().length - 1];

export const backDoorPassword = (word) => word[0].toUpperCase() + word.slice(1).toLowerCase() + ", please";
