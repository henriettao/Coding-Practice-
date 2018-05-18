#include <stdio.h>

int printUnion(int arr1[], int arr2[], int m, int n)
{
	int i= 0; int j=0;
	while (i< m && j< n)
	{
		if(arr1[i]< arr2[j])
		{
			printf("%d, ", arr1[i++]);
			i++;
		}

		else if (arr1[i]> arr2[j])
		{
			printf("%d,", arr2[j++]);
			
			j++;
		}
		else 
		{
			printf("%d,", arr2[j++]);
			i++;
		}
		
	}

	while(i < m)
	{
		printf("%d,", arr1[i++]);
	}

	while(j < n)
	{
		printf("%d,", arr2[j++]);	
	}
	printf("\n");
	
}

int printIntersection(int arr1[], int arr2[], int m, int n)
{
	int i = 0; int j= 0;
	while (i < m && j< n)
	{	if (arr1[i]< arr2[j])
		{
			i++;
		}
		else if (arr1[i] > arr2[j])
		{
			j++;
		}
		if (arr1[i] == arr2[j])
		{
			printf("%d, ", arr1[i]);
			i++; j++;
		}
	}
}

int main()
{
	int arr1[] = {2,10,14,19,51,71};
	int arr2[] = {2,9,19,40,51};

	int m = sizeof(arr1)/ sizeof(arr1[0]);
	int n = sizeof(arr2)/ sizeof (arr2[0]);

	printf("%d, %d\n", m,n);
	printf("The Union of the Arrays \n");
	printUnion(arr1, arr2, m,n);
	printf("\n");

	printf("The Intersection of the Arrays \n");	
	printIntersection(arr1, arr2, m,n);
	printf("\n");
	return 0;


}
