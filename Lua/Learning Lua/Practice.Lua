--Practicing the tutorial from mindset.


--text constants
sTxtParametersIncomplete = "Parameter Incomplete";

--the current plu number for the difference between receipt and 
--minimum consumption value
minConsumptionPLUNo = 980;

--minimum consumption value
minConsumptionValue = 12;

--the media on which minimum consumption should apply
--payment type basically
minConsumptionMedia = {1,2,4};


--THEO - How would this work exactly alongside Vectron? Since i havent imported any classes etc.

--Register the event for ApplyMinConsumption
vpos.events.registerEventFunction(vpos.events.OnMediaBeforePayment, "ApplyMinConsumption");

--function for applying the minimum consumption PLU to the receipt
fucntion ApplyMinConsumption(event)
end;

 


--Applying the minimum consumption PLU to the receipt
function ApplyMinConsumption (event)
--check parameters
if(minConsumptionPLUNo == nil or minConsumptionValue == nil or minConsumptionMedia == nil) then
    vpos.view.showWindow(sTxtParametersIncomplete);
    return;
else
    --get current media
    local media = event:getMedia();
    if(media == nil) then
        return
    end;
    --get current media number
    local mediaNo = media:getNo();
    if(mediaNo == nil) then
    return;
end;

--set default value
local mediaIsRegistered = false;

--if media is viable for minimum consumption
for index, value in ipairs (minConsumptionMedia) do
    if(mediaNo == value) then
        mediaIsRegistered = true;
        break;
    end;
end;

if(mediaIsRegistered) then
    --get the current receipt
    local receipt = vpos.accounting.Receipt ();
    if(receipt == nil) then
        return;
    end;
    --get the current receipt value
    local currentReceiptValue = receipt:getSubTotal();
    if(currentReceiptValue == nil) then
        return;
    end;

    --check if the minimum consumption has been reached.
    if(currentReceiptValue < minConsumptionValue) then
        receipt:addPLU {plu = minConsumptionPLUNo, price = minConsumptionValue - currentReceiptValue}
    end;
end;



--OVERVIEW PRACTICE SECTION
--Setting global and local variables
minConsumptionPLUNo = 980;
mediaIsRegistered = false;

--If/else statements
if(minConsumptionPLUNo == nil or minConsumptionValue == nil or minConsumptionMedia == nil) then
    vpos.view.showWindow(sTxtParametersIncomplete);
    return;
else

end;

--for loops and stateless ipairs iterator:
for index, value in ipairs(minConsumptionMedia) do
    if(mediaNo == value) then
        mediaIsRegistered = true;
    end;
end;

--Creating own functions
functions ApplyMinConsumption(event)
end;

--Register a function for an event
vpos.events.registerEventFunction(vpos.events.OnMediaBeforePayment, "onMediaBeforePayment", "ApplyMinConsumption");

--show an info window:
vpos.view.showWindow(sTxtParametersIncomplete);

--Media Object:
media = event:getMedia();

--Media number
mediaNo = media:getNo();

--Class for receipt object:
receipt = vpos.accounting.Receipt();
currentReceiptValue = receipt:getSubTotal();
receipt:addPLU{plu = minConsumptionPLUNo, price = minConsumptionValue - currentReceiptValue} 


---------- E V E R Y T H I N G  P U T  T O G E T H E R ----------
--text constants
sTxtParametersIncomplete = "Parameter Incomplete";

--the current plu number for the difference between receipt and 
--minimum consumption value
minConsumptionPLUNo = 980;

--minimum consumption value
minConsumptionValue = 12;

--the media on which minimum consumption should apply
--payment type basically
minConsumptionMedia = {1,2,4};

--Applying the minimum consumption PLU to the receipt
function ApplyMinConsumption (event)
    --check parameters
    if(minConsumptionPLUNo == nil or minConsumptionValue == nil or minConsumptionMedia == nil) then
        vpos.view.showWindow(sTxtParametersIncomplete);
        return;
    else
        --get current media
        local media = event:getMedia();
        if(media == nil) then
            return
        end;
        --get current media number
        local mediaNo = media:getNo();
        if(mediaNo == nil) then
        return;
    end;
    
    --set default value
    local mediaIsRegistered = false;
    
    --if media is viable for minimum consumption
    for index, value in ipairs (minConsumptionMedia) do
        if(mediaNo == value) then
            mediaIsRegistered = true;
            break;
        end;
    end;
    
    if(mediaIsRegistered) then
        --get the current receipt
        local receipt = vpos.accounting.Receipt ();
        if(receipt == nil) then
            return;
        end;
        --get the current receipt value
        local currentReceiptValue = receipt:getSubTotal();
        if(currentReceiptValue == nil) then
            --minimum valu ereach
            return;
        end;
    
        --check if the minimum consumption has been reached.
        if(currentReceiptValue < minConsumptionValue) then
            --book a plu
            receipt:addPLU {plu = minConsumptionPLUNo, price = minConsumptionValue - currentReceiptValue}
        end;
    end;
end;

end; -- what is this last one ending? No other methods there.


    