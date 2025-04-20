def Tower (n, fromStack, toStack, spareStack):
    if n == 1:
        print(f'Move disk from {fromStack} to {toStack}') #
    else:
        Tower(n-1, fromStack, spareStack, toStack) #spare will be toStack (moving n - 1 disk which is all smaller than the base disk from source rod to spare rod)
        Tower(1, fromStack, toStack, spareStack) # (move the largest disk to the destination rod)
        Tower(n-1, spareStack, toStack, fromStack) # (lastly, move the n - 1 disk which are the disk is all smaller than largest disk to the destination rod)


Tower(3, 'Rod 1', 'Rod 3', 'Rod 2') #from Rod 1 to Rod 3 left with spare which is Rod 2