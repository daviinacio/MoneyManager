CREATE FUNCTION [dbo].[GetWorkingDay]
(@MonthDate	DATE, @Day INT)
RETURNS DATE
AS
     BEGIN
         DECLARE @DayCount INT = 0;
		 DECLARE @tMonthDate DATE = @MonthDate;

		 SET @MonthDate = DATEADD(DAY, -(DATEPART(DAY, @MonthDate) -1), @MonthDate);

		 WHILE DATEPART(DAY, @MonthDate) <= 30
             BEGIN

				IF DATENAME(WEEKDAY, @MonthDate) IN('Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday')
                     BEGIN
                         SET @DayCount = @DayCount + 1;
				     END;
				
				-- If the working days reach [day], return the current count days --
				IF @DayCount >= @Day
					BEGIN
						RETURN @MonthDate;
					END;

				-- Increment the date --
				SET @MonthDate = DATEADD(DAY, 1, @MonthDate);
             END;
         RETURN @tMonthDate;
     END;
GO